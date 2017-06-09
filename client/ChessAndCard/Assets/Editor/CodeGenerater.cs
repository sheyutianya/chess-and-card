using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class CodeGenerater
{
    [MenuItem("Export/CSV_class")]
    static public void DoGenerateDirectory()
    {
        GenerateDirectory(
            Application.dataPath + "/StreamingAssets/",
            Application.dataPath + "/Script/CSVTemplate.cs"
        );
    }

    //遍历inputDir目录下所有csv文件,将文件生成cs文件
    public static void GenerateDirectory(string inputDir, string outputName)
    {
        string[] fileList = Directory.GetFiles(inputDir, "*.csv", SearchOption.TopDirectoryOnly);
        CSFile csFile = new CSFile();
        foreach (string fileName in fileList)
        {
            using (StreamReader sr = File.OpenText(fileName))
            {
                string className = GetFileName(fileName);
                csFile.Add(className, GetText(className, sr.ReadToEnd()));
            }
        }

        using (StreamWriter sw = File.CreateText(outputName))
        {
            sw.Write(csFile.Generate());
        }
    }

    //通过类名和csv文本,返回cs文件的内容(一个C#类的定义)
    private static CSClass GetText(string className, string sourceText)
    {
        string[] lineList = sourceText.Split('\n');
        string[] keyList = ParseLine(lineList[0].Trim());
        string[] typeList = ParseLine(lineList[1].Trim());

        CSClass cs = new CSClass(className);

        for (int i = 0, n = keyList.Length; i < n; i++){
            cs.AddField(keyList[i], typeList[i]);
        }

        return cs;
	}

    //将一行csv文本生成一个以','分割的string数组
    static private string[] ParseLine(string line)
    {
        string[] itemList = line.Split(',');
        string[] result = new string[itemList.Length];
        for (int i = 0, n = itemList.Length; i < n; i++)
        {
            result[i] = itemList[i].Trim();
        }
        return result;
    }

    //通过文件路径返回文件名(不带后缀)
    static public string GetFileName(string filePath)
    {
        int index = filePath.LastIndexOf("/");
        if(index >= 0){
            filePath = filePath.Substring(index + 1);
        }
        index = filePath.IndexOf(".");
        if(index >= 0){
            return filePath.Substring(0, index);
        }
        return filePath;
    }
}

class CSFile
{
    public const string CSV_FILE_STR = @"
using Core.Net.Http;
using Core.CSV;
using UnityEngine;
using System.Collections;
using System;

public class CSVTemplate
{
    static public string csvDir = Application.streamingAssetsPath;
    private const int fileCount = #{fileCount};
    static private int currentCount = 0;

    static public void Init(Action onLoadComplete)
    {
        #{init}
    }

    private static void RegisterCSV<T>(string name, string fileData, Action onLoadComplete) where T : BaseTemplate, new()
    {
        CSVManager.GetInstance().Register<T>(name, fileData);
        if(++currentCount >= fileCount){
            if(onLoadComplete != null){
                onLoadComplete();
            }
        }
    }
}
#{classDef}
";

    private Dictionary<string, CSClass> fileDict = new Dictionary<string, CSClass>();

    public void Add(string filePath, CSClass csvClass)
    {
        fileDict.Add(filePath, csvClass);
    }

    private string GetInitStr(string filePath)
    {
        string className = CodeGenerater.GetFileName(filePath);
        string templateStr = "HttpManager.GetText(csvDir + \"/#{0}.csv\", text => RegisterCSV<#{1}>(\"#{2}\", text, onLoadComplete));";
        templateStr = templateStr.Replace("#{0}", filePath);
        templateStr = templateStr.Replace("#{1}", className);
        templateStr = templateStr.Replace("#{2}", className);
        return templateStr;
    }

    public string Generate()
    {
        var initStr = "";
        var classDef = "";
        foreach (var pair in fileDict)
        {
            initStr += GetInitStr(pair.Key) + "\n\t\t";
            classDef += pair.Value.Generate() + "\n";
        }

        string result = CSV_FILE_STR.Replace("#{init}", initStr);
        result = result.Replace("#{fileCount}", fileDict.Count.ToString());
        result = result.Replace("#{classDef}", classDef);
        return result;
    }
}

//C#类文件定义
class CSClass
{
    public const string CSV_CLASS_STR = @"
public class #{className} : BaseTemplate
{
    #{fieldList}
}
";


    private string className;
    private List<Pair> pairList = new List<Pair>();

    //className为类名
    public CSClass(string className)
    {
        this.className = className;
    }
    //添加字段
    public void AddField(string name, string type)
    {
        pairList.Add(new Pair(name, type));
    }

    //返回生成的C#类定义文本
    public string Generate()
    {
        string fieldString = "";
        pairList.ForEach(pair => { fieldString += pair.ToString() + "\n\t"; });
        string result = CSV_CLASS_STR.Replace("#{className}", className);
        result = result.Replace("#{fieldList}", fieldString);
        return result;
    }

    //C#字段的名字和类型信息
    private class Pair
    {
        public string name;
        public string type;

        public Pair(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            return "public " + type + " " + name + ";";
        }
    }
}


