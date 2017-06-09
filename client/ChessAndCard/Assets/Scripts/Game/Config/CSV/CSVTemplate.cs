
//using Core.Net.Http;
using Core.CSV;
using UnityEngine;
using System.Collections;
using System;

public class CSVTemplate
{
    static public string csvDir = Application.streamingAssetsPath;
    private const int fileCount = 2;
    static private int currentCount = 0;

    static public void Init(Action onLoadComplete)
    {
        //HttpManager.GetText(csvDir + "/Skill.csv", text => RegisterCSV<Skill>("Skill", text, onLoadComplete));
		//HttpManager.GetText(csvDir + "/version.csv", text => RegisterCSV<version>("version", text, onLoadComplete));	
    }

    private static void RegisterCSV<T>(string name, string fileData, Action onLoadComplete) where T : BaseTemplate, new()
    {
        CSVManager.Instance.Register<T>(name, fileData);
        if(++currentCount >= fileCount){
            if(onLoadComplete != null){
                onLoadComplete();
            }
        }
    }
}

public class Skill : BaseTemplate
{
    public int id;
	public string name;	
}


public class version : BaseTemplate
{
    public int id;
	public string path;
	public string md5;
	public int size;	
}


