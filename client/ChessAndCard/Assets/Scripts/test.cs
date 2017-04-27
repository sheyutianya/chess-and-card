using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UIFrameWord.UI;
using UnityEngine;

public class test : MonoBehaviour {

    /// <summary>
    /// 初始化游戏管理器
    /// </summary>
    void Awake()
    {
        Init();
    }

    /// <summary>
    /// 初始化
    /// </summary>
    void Init()
    {
        DontDestroyOnLoad(gameObject);  //防止销毁自己

        CheckExtractResource(); //释放资源
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        //Application.targetFrameRate = AppConst.GameFrameRate;
    }

	// Use this for initialization
    void Start()
    {
        int i = 4;
        Debug.Log(i);
        //TTUIPage.ShowPage<UITestPage>();
    }

	// Update is called once per frame
    //void Update () {
		
    //}

    /// <summary>
    /// 每一帧被调用多次,enabled=false时禁用
    /// </summary>
    void OnGUI()
    {
        int cwidth = Screen.width / 2;
        int cheight = Screen.height / 2;
        //var boxPos = new Rect(cwidth - 110, cheight - 160, 240, 120);

        if (GUI.Button(new Rect(cwidth - 100, cheight - 80, 80, 22), "Regist"))
        {
            NetWriter.SetUrl("127.0.0.1:9001");
            Net.Instance.Send((int)ActionType.Regist, RegistCallback, null);
        }

        if (GUI.Button(new Rect(cwidth, cheight - 80, 80, 22), "Login"))
        {
            NetWriter.SetUrl("http://127.0.0.1:6688/Service.aspx/",ResponseContentType.Stream,true);
            Net.Instance.Send((int)ActionType.GetRes, RegistCallback, null);
        }
    }

    private void RegistCallback(ActionResult actionResult)
    {
        if (actionResult != null)
        {
            string user = actionResult.Get<string>("passportID");
            string pwd = actionResult.Get<string>("password");
            Debug.Log("username:" + user + " password:" + pwd);
        }
    }

    /// <summary>
    /// 释放资源
    /// </summary>
    public void CheckExtractResource()
    {
        bool isExists = Directory.Exists(Util.DataPath) && File.Exists(Util.DataPath + "files.txt");

        if (isExists)
        {
            StartCoroutine(OnUpdateResource());
            return;   //文件已经解压过了，自己可添加检查文件列表逻辑
        }
        StartCoroutine(OnExtractResource());    //启动释放协成 
    }

    IEnumerator OnExtractResource()
    {
        string dataPath = Util.DataPath;  //数据目录
        string resPath = Util.AppContentPath(); //游戏包资源目录

        if (Directory.Exists(dataPath)) Directory.Delete(dataPath, true);
        Directory.CreateDirectory(dataPath);

        string infile = resPath + "files.txt";
        string outfile = dataPath + "files.txt";
        if (File.Exists(outfile)) File.Delete(outfile);

        string message = "正在解包文件:>files.txt";
        Debug.Log(message);
        //facade.SendMessageCommand(NotiConst.UPDATE_MESSAGE, message);

        if (Application.platform == RuntimePlatform.Android)
        {
            WWW www = new WWW(infile);
            yield return www;

            if (www.isDone)
            {
                File.WriteAllBytes(outfile, www.bytes);
            }
            yield return 0;
        }
        else File.Copy(infile, outfile, true);
        yield return new WaitForEndOfFrame();

        //释放所有文件到数据目录
        string[] files = File.ReadAllLines(outfile);
        foreach (var file in files)
        {
            string[] fs = file.Split('|');
            infile = resPath + fs[0];  //
            outfile = dataPath + fs[0];

            message = "正在解包文件:>" + fs[0];
            Debug.Log("正在解包文件:>" + infile);
            //facade.SendMessageCommand(NotiConst.UPDATE_MESSAGE, message);

            string dir = Path.GetDirectoryName(outfile);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            if (Application.platform == RuntimePlatform.Android)
            {
                WWW www = new WWW(infile);
                yield return www;

                if (www.isDone)
                {
                    File.WriteAllBytes(outfile, www.bytes);
                }
                yield return 0;
            }
            else
            {
                if (File.Exists(outfile))
                {
                    File.Delete(outfile);
                }
                File.Copy(infile, outfile, true);
            }
            yield return new WaitForEndOfFrame();
        }
        message = "解包完成!!!";
        //facade.SendMessageCommand(NotiConst.UPDATE_MESSAGE, message);
        Debug.Log(message);

        yield return new WaitForSeconds(0.1f);
        message = string.Empty;

        //释放完成，开始启动更新资源
        StartCoroutine(OnUpdateResource());
    }

    private List<string> downloadFiles = new List<string>();
    /// <summary>
    /// 启动更新下载，这里只是个思路演示，此处可启动线程下载更新
    /// </summary>
    IEnumerator OnUpdateResource()
    {
        downloadFiles.Clear();

        //if (!AppConst.UpdateMode)
        //{
        //    ResManager.initialize(OnResourceInited);
        //    yield break;
        //}
        string dataPath = Util.DataPath;  //数据目录
        string url = AppConst.WebUrl;

        GameAction gameAction = ActionFactory.Create(1009);
        if (gameAction == null)
        {
            throw new ArgumentException(string.Format("Not found {0} of GameAction object.", 1009));
        }

        NetWriter.SetUrl("http://127.0.0.1:6688/Service.aspx/", ResponseContentType.Stream, true);
        ActionParam actionParam = new ActionParam();
        actionParam["url"] = "files.txt";  
        byte[] postData = gameAction.Send(actionParam);
        Debug.LogWarning("LoadUpdate---->>>" + url);
        WWW www = new WWW(string.Format("{0}?{1}", url, Encoding.UTF8.GetString(postData)));
        yield return www;
        NetWriter.resetData();
        if (www.error != null)
        {
            OnUpdateFailed(string.Empty);
            yield break;
        }
        if (!Directory.Exists(dataPath))
        {
            Directory.CreateDirectory(dataPath);
        }
        File.WriteAllBytes(dataPath + "files.txt", www.bytes);


        //string random = DateTime.Now.ToString("yyyymmddhhmmss");
        //string listUrl = url + "files.txt?v=" + random;
        //Debug.LogWarning("LoadUpdate---->>>" + listUrl);

        //WWW www = new WWW(listUrl); yield return www;
        //if (www.error != null)
        //{
        //    OnUpdateFailed(string.Empty);
        //    yield break;
        //}
        //if (!Directory.Exists(dataPath))
        //{
        //    Directory.CreateDirectory(dataPath);
        //}
        //File.WriteAllBytes(dataPath + "files.txt", www.bytes);

        //string filesText = www.text;
        //string[] files = filesText.Split('\n');

        //string message = string.Empty;
        //for (int i = 0; i < files.Length; i++)
        //{
        //    if (string.IsNullOrEmpty(files[i])) continue;
        //    string[] keyValue = files[i].Split('|');
        //    string f = keyValue[0];
        //    string localfile = (dataPath + f).Trim();
        //    string path = Path.GetDirectoryName(localfile);
        //    if (!Directory.Exists(path))
        //    {
        //        Directory.CreateDirectory(path);
        //    }
        //    string fileUrl = url + keyValue[0] + "?v=" + random;
        //    bool canUpdate = !File.Exists(localfile);
        //    if (!canUpdate)
        //    {
        //        string remoteMd5 = keyValue[1].Trim();
        //        string localMd5 = Util.md5file(localfile);
        //        canUpdate = !remoteMd5.Equals(localMd5);
        //        if (canUpdate) File.Delete(localfile);
        //    }
        //    if (canUpdate)
        //    {   //本地缺少文件
        //        Debug.Log(fileUrl);
        //        message = "downloading>>" + fileUrl;
        //        //facade.SendMessageCommand(NotiConst.UPDATE_MESSAGE, message);
        //        /*
        //        www = new WWW(fileUrl); yield return www;
        //        if (www.error != null) {
        //            OnUpdateFailed(path);   //
        //            yield break;
        //        }
        //        File.WriteAllBytes(localfile, www.bytes);
        //         * */
        //        //这里都是资源文件，用线程下载
        //        //BeginDownload(fileUrl, localfile);
        //        while (!(IsDownOK(localfile))) { yield return new WaitForEndOfFrame(); }
        //    }
        //}
        //yield return new WaitForEndOfFrame();
        //message = "更新完成!!";
        ////facade.SendMessageCommand(NotiConst.UPDATE_MESSAGE, message);

        ////ResManager.initialize(OnResourceInited);
    }

    /// <summary>
    /// 是否下载完成
    /// </summary>
    bool IsDownOK(string file)
    {
        return downloadFiles.Contains(file);
    }

    ///// <summary>
    ///// 线程下载
    ///// </summary>
    //void BeginDownload(string url, string file)
    //{     //线程下载
    //    object[] param = new object[2] { url, file };

    //    ThreadEvent ev = new ThreadEvent();
    //    ev.Key = NotiConst.UPDATE_DOWNLOAD;
    //    ev.evParams.AddRange(param);
    //    ThreadManager.AddEvent(ev, OnThreadCompleted);   //线程下载
    //}

    ///// <summary>
    ///// 线程完成
    ///// </summary>
    ///// <param name="data"></param>
    //void OnThreadCompleted(NotiData data)
    //{
    //    switch (data.evName)
    //    {
    //        case NotiConst.UPDATE_EXTRACT:  //解压一个完成
    //            //
    //            break;
    //        case NotiConst.UPDATE_DOWNLOAD: //下载一个完成
    //            downloadFiles.Add(data.evParam.ToString());
    //            break;
    //    }
    //}

    void OnUpdateFailed(string file)
    {
        string message = "更新失败!>" + file;
        Debug.LogWarning("OnUpdateFailed---->>>" + message);
        //facade.SendMessageCommand(NotiConst.UPDATE_MESSAGE, message);
    }
}
