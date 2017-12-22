using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class testbuild
{

    //具体到文件夹
    private static List<string> m_packPathList = new List<string>()
    {
        //武将动作Animations
        "Resources/Animations/M0001",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",
        "Resources/Animations/M0002",

    };

    public static string sourcePath = Application.dataPath + "/Resources";
    static string errorStr = "";

    [MenuItem("DebugMsg/RenameAllBundlesName")]
    public static void RenameAssetBundle()
    {
        Rename(sourcePath);   //重命名所有Resources下的所有文件

        AssetDatabase.Refresh();

        if (!string.IsNullOrEmpty(errorStr)) Debug.LogError("errorStr::" + errorStr);
        Debug.Log("重命名完成");
    }

    /// <summary>
    /// 递归获取所有文件
    /// </summary>
    /// <param name="source"></param>
    static void Rename(string source)
    {
        DirectoryInfo folder = new DirectoryInfo(source);
        FileSystemInfo[] files = folder.GetFileSystemInfos();
        int length = files.Length;
        for (int i = 0; i < length; i++)
        {
            string tempPath = Replace(files[i].FullName);
            tempPath = tempPath.Substring(Application.dataPath.Length+1);

            if (files[i] is DirectoryInfo)
            {
                if (m_packPathList.Contains(tempPath))
                {
                    SetBundleName(tempPath);
                }
                else 
                {
                    Rename(files[i].FullName);
                }
            }
            else
            {
                //if (!files[i].Name.EndsWith(".meta") && !files[i].Name.EndsWith(".DS_Store"))
                //{
                //    SetBundleName(files[i].FullName);
                //}
            }
        }
    }

    /// <summary>
    /// 设置AssetBundleName
    /// </summary>
    /// <param name="source"></param>
    static void SetBundleName(string source)
    {
        string _source = source;//Replace(source);

        string _assetPath = "Assets/" + _source;

        //在代码中给资源设置AssetBundleName
        AssetImporter assetImporter = AssetImporter.GetAtPath(_assetPath);

        assetImporter.assetBundleName = source;
    }

    static string Replace(string s)
    {
        return s.Replace("\\", "/");
    }

    /// <summary>
    /// 清除之前设置过的AssetBundleName，避免产生不必要的资源也打包
    /// 之前说过，只要设置了AssetBundleName的，都会进行打包，不论在什么目录下
    /// </summary>  
    [MenuItem("DebugMsg/ClearAllBundlesName")]
    static void ClearAssetBundlesName()
    {
        int length = AssetDatabase.GetAllAssetBundleNames().Length;
        Debug.Log("当前有：" + length + "个Bundle");
        string[] oldAssetBundleNames = new string[length];
        for (int i = 0; i < length; i++)
        {
            oldAssetBundleNames[i] = AssetDatabase.GetAllAssetBundleNames()[i];
        }

        for (int j = 0; j < oldAssetBundleNames.Length; j++)
        {
            AssetDatabase.RemoveAssetBundleName(oldAssetBundleNames[j], true);
        }
        length = AssetDatabase.GetAllAssetBundleNames().Length;
    }

    static List<string> paths = new List<string>();
    static List<string> files = new List<string>();
    /// <summary>
    /// 数据目录
    /// </summary>
    static string AppDataPath
    {
        get { return Application.dataPath.ToLower(); }
    }

    [MenuItem("DebugMsg/BuildFileIndex")]
    static void BuildFileIndex()
    {
        string resPath = AppDataPath + "/StreamingAssets/";
        ///----------------------创建文件列表-----------------------
        string newFilePath = resPath + "/files.txt";
        if (File.Exists(newFilePath)) File.Delete(newFilePath);

        paths.Clear(); files.Clear();
        Recursive(resPath);

        FileStream fs = new FileStream(newFilePath, FileMode.CreateNew);
        StreamWriter sw = new StreamWriter(fs);
        for (int i = 0; i < files.Count; i++)
        {
            string file = files[i];
            //string ext = Path.GetExtension(file);
            if (file.EndsWith(".meta") || file.Contains(".DS_Store")) continue;

            string md5 = Util.md5file(file);
            string value = file.Replace(resPath, string.Empty);
            sw.WriteLine(value + "|" + md5);
        }
        sw.Close(); fs.Close();
    }

    /// <summary>
    /// 遍历目录及其子目录
    /// </summary>
    static void Recursive(string path)
    {
        string[] names = Directory.GetFiles(path);
        string[] dirs = Directory.GetDirectories(path);
        foreach (string filename in names)
        {
            string ext = Path.GetExtension(filename);
            if (ext.Equals(".meta")) continue;
            files.Add(filename.Replace('\\', '/'));
        }
        foreach (string dir in dirs)
        {
            paths.Add(dir.Replace('\\', '/'));
            Recursive(dir);
        }
    }

}
