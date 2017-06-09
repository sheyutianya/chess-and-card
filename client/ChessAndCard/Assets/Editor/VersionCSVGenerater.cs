//using System.Collections.Generic;
//using System.IO;
//using System.Security.Cryptography;
//using System.Text;
//using Core.Managers;
//using UnityEditor;

//public class VersionCSVGenerater
//{
//    public static string VERSION_FILE_NAME = "version.csv";

//    private static List<VersionItem> fileList;
//    //资源目录
//    private static string folderPath;

//    [MenuItem("Export/VersionCSV")]
//    static public void Start ()
//    {
//        folderPath = EditorUtility.OpenFolderPanel("choose folder", string.Empty, string.Empty);
//        if (folderPath.Length <= 0)
//        {
//            return;
//        }

//        fileList = new List<VersionItem>();
//        VersionManager.WalkDir(folderPath, HandleFile);

//        string result = "id,path,md5,size\r\nint,string,string,int\r\n,,,\r\n";
//        foreach (var versionItem in fileList)
//        {
//            result += versionItem.id + "," + versionItem.path + "," + versionItem.md5 + "," + versionItem.size + "\r\n";
//        }

//        File.WriteAllText(Path.Combine(folderPath, VERSION_FILE_NAME), result);

//        fileList = null;
//        folderPath = null;
//    }

//    static void HandleFile(string filePath)
//    {
//        if (filePath.EndsWith(".meta") || filePath.EndsWith(VERSION_FILE_NAME))
//        {
//            return;
//        }

//        var versionItem = new VersionItem();
//        var fileBytes = File.ReadAllBytes(filePath);

//        versionItem.id = fileList.Count;
//        versionItem.path = filePath.Substring(folderPath.Length+1);
//        versionItem.md5 = GetMd5Hash(fileBytes);
//        versionItem.size = fileBytes.Length;

//        fileList.Add(versionItem);
//    }

//    static string GetMd5Hash(byte[] input)
//    {
//        MD5 md5Hash = MD5.Create();
//        // Convert the input string to a byte array and compute the hash.
//        byte[] data = md5Hash.ComputeHash(input);

//        // Create a new Stringbuilder to collect the bytes
//        // and create a string.
//        StringBuilder sBuilder = new StringBuilder();

//        // Loop through each byte of the hashed data 
//        // and format each one as a hexadecimal string.
//        for (int i = 0; i < data.Length; i++)
//        {
//            sBuilder.Append(data[i].ToString("x2"));
//        }

//        // Return the hexadecimal string.
//        return sBuilder.ToString();
//    }
//}
