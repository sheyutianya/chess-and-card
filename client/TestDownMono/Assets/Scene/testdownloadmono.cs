using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

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
        progress = 0;
#if UNITY_ANDROID
        StartCoroutine(loadAsset());
#endif

        Debug.Log("1.0");
    }

    string version = "1.0";

    IEnumerator loadAsset()
    {
#if UNITY_EDITOR
        WWW txt = new WWW("ftp://192.168.1.58:21/readme.txt");
        yield return txt;
        string text = txt.text;
        SaveBytes(Application.persistentDataPath + "/", "readme.txt", txt.bytes);
        if (text != version)
        {
            www = new WWW("ftp://192.168.1.58:21/Assembly-CSharp.dll");
            yield return www;
            byte[] bytes = www.bytes;
            SaveBytes(Application.persistentDataPath + "/", "Assembly-CSharp.dll", bytes);
            yield return new WaitForEndOfFrame();
            restartApplication();
        }
#else
        string datapath = Application.dataPath;
        int start = datapath.IndexOf ("com.");
        int end = datapath.IndexOf ("-");
        string packagename = datapath.Substring (start,end-start);
        string path = "/data/data/"+packagename+"/files/";
        WWW txt = new WWW ("ftp://192.168.1.58:8083/readme.txt");
        yield return txt;
        string text = txt.text;
        SaveBytes (path,"readme.txt",txt.bytes);
        if (text != version) {
            www = new WWW ("ftp://192.168.1.58:21/Assembly-CSharp.dll");
            yield return www;
            byte[] bytes = www.bytes;
            SaveBytes (path,"Assembly-CSharp.dll",bytes);
            yield return new WaitForEndOfFrame ();
            restartApplication ();
        }
#endif

    }

    void SaveBytes(string path, string filename, byte[] bytes)
    {
        Debug.Log(path + filename);
        label.text = path + filename;
        Directory.CreateDirectory(path);
        FileInfo file = new FileInfo(path + filename);
        if (file.Exists)
        {
            file.Delete();
        }
        var sw = file.Create();
        sw.Write(bytes, 0, bytes.Length);
        sw.Close();
        sw.Dispose();
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