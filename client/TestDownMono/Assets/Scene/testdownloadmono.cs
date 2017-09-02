using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class testdownloadmono : MonoBehaviour
{

    public Image bar = null;
    public Text label = null;
    float progress
    {
        get
        {
            if (bar != null)
            {
                return bar.fillAmount;
            }
            return 1.0f;
        }
        set
        {
            float v = value;
            if (v > 1.0f)
            {
                v = 1.0f;
            }
            if (bar != null)
            {
                bar.fillAmount = v;
            }
        }
    }
    WWW www = null;
    // Use this for initialization
    void Start()
    {
        Debug.Log("3.0");
        progress = 0;
        StartCoroutine(loadVersion());
    }

    string version = "1.0";

    IEnumerator loadVersion() 
    {
        yield return new WaitForEndOfFrame();
#if UNITY_ANDROID
        string datapath = Application.dataPath;
        int start = datapath.IndexOf("com.");
        int end = datapath.IndexOf("-");
        string packagename = datapath.Substring(start, end - start);
        string path = "/data/data/" + packagename + "/files/";

        if (System.IO.File.Exists(path + "readme.txt"))
        {
            //WWW txt = new WWW(path + "readme.txt");
            //yield return txt;
            //version = txt.text;
            Debug.Log("LoadPath:" + path + "readme.txt");

            FileStream readstream = new FileStream(path + "readme.txt", FileMode.Open);
            TextReader reader = new StreamReader(readstream, new UTF8Encoding());
            version = reader.ReadToEnd();
            Debug.Log("loadVersion:" + version);
            Debug.Log("loadVersion2:" + reader.ReadToEnd());

            StartCoroutine(loadAsset());
        }
        else//streamingAssets 目录在安卓下是压缩包，不能用接口检测存不存在
        {
            StartCoroutine(loadAsset());
        }
#endif
    }

    string readmepath = "http://192.168.1.58/readme.txt";
    string dllpath = "http://192.168.1.58/Assembly-CSharp.dll";

    IEnumerator loadAsset()
    {
//#if UNITY_EDITOR
//        WWW txt = new WWW(readmepath);
//        yield return txt;
//        string text = txt.text;
//        SaveBytes(Application.persistentDataPath + "/", "readme.txt", txt.bytes);
//        if (text != version)
//        {
//            www = new WWW(dllpath);
//            yield return www;
//            byte[] bytes = www.bytes;
//            SaveBytes(Application.persistentDataPath + "/", "Assembly-CSharp.dll", bytes);
//            yield return new WaitForEndOfFrame();
//            restartApplication();
//        }
//#endif 
#if UNITY_ANDROID
        string datapath = Application.dataPath;
        int start = datapath.IndexOf("com.");
        int end = datapath.IndexOf("-");
        string packagename = datapath.Substring(start, end - start);
        string path = "/data/data/" + packagename + "/files/";
        WWW txt = new WWW(readmepath);
        yield return txt;
        string text = txt.text;
        Debug.Log("srcversion:" + version + " targetversion:" + text);
        SaveBytes(path, "readme.txt", txt.bytes);
        if (text != version)
        {
            Debug.Log("更新版本" + text);
            www = new WWW(dllpath);
            yield return www;
            byte[] bytes = www.bytes;
            SaveBytes(path, "Assembly-CSharp.dll", bytes);
            yield return new WaitForEndOfFrame();
            restartApplication();
        }
#endif

    }

    void SaveBytes(string path, string filename, byte[] bytes)
    {
        Debug.Log(path + filename);
        label.text = path + filename;
        Directory.CreateDirectory(path);
        //FileInfo file = new FileInfo(path + filename);
        //if (file.Exists)
        //{
        //    file.Delete();
        //}
        //Debug.Log("SaveBytes:" + path + filename);
        //var sw = file.Create();
        //sw.Write(bytes, 0, bytes.Length);
        //Debug.Log("SaveBytes:" + bytes.Length + filename);
        //sw.Flush();
        //sw.Close();
        //sw.Dispose();

        Debug.Log("SaveBytes:" + path + filename);
        FileStream stream = new FileStream(path + filename, FileMode.Create);
        stream.Write(bytes, 0, bytes.Length);
        stream.Flush();
        stream.Close();
        Debug.Log("SaveBytes:" + bytes.Length + filename);

        FileStream readstream = new FileStream(path + filename, FileMode.Open);
        TextReader reader = new StreamReader(readstream, new UTF8Encoding());

        //byte[] readdata = new byte[bytes.Length];
        //readstream.Read(readdata,0,bytes.Length);
        Debug.Log("llllLoad:" + reader.ReadToEnd());
    }

    void restartApplication(){
        Debug.Log ("restartApplication0");
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        Debug.Log ("restartApplication1");
        jo.Call("restartApplication");
        Debug.Log ("restartApplication2");
    }


    // Update is called once per frame
    void Update() {
        if (www != null) {
            float _p = www.progress;
            if (progress < _p) {
                progress = _p;
            }
        } else {
            progress += 0.01f;
        }
    }
}