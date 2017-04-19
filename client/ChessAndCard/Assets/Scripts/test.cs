using System.Collections;
using System.Collections.Generic;
using UIFrameWord.UI;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        int i = 4;
        Debug.Log(i);
        TTUIPage.ShowPage<UITestPage>();
    }

	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// 每一帧被调用多次,enabled=false时禁用
    /// </summary>
    void OnGUI()
    {
        int cwidth = Screen.width / 2;
        int cheight = Screen.height / 2;
        var boxPos = new Rect(cwidth - 110, cheight - 160, 240, 120);

        if (GUI.Button(new Rect(cwidth - 100, cheight - 80, 80, 22), "Regist"))
        {
            NetWriter.SetUrl("127.0.0.1:9001");
            Net.Instance.Send((int)ActionType.Regist, RegistCallback, null);
        }

        if (GUI.Button(new Rect(cwidth, cheight - 80, 80, 22), "Login"))
        {
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
}
