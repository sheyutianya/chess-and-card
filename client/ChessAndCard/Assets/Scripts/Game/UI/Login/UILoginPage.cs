using GameP;
using System;
using System.Collections;
using System.Collections.Generic;
using UIFrameWork.UI;
using UnityEngine;
using UnityEngine.UI;

public class UILoginPage : TTUIPage
{

    GameObject mLoginBtn;
    GameObject mChatBtn;
    Text mChatMsg;

    public UILoginPage()
        : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UI/panel/login/login_panel";
    }

    public override void Awake(GameObject go)
    {
        mLoginBtn = this.transform.Find("btn_login").gameObject;
        mLoginBtn.GetComponent<Button>().onClick.AddListener(delegate() 
        {
            OnClickLoginBtn(mLoginBtn);
        });

        mChatBtn = this.transform.Find("btn_chat").gameObject;
        mChatBtn.GetComponent<Button>().onClick.AddListener(delegate()
        {
            OnClickChatBtn(mChatBtn);
        });

        mChatMsg = this.transform.Find("txt_chatmsg").gameObject.GetComponent<Text>();

        Action1002.PushCallBack += ChatCallback;
    }

    void OnClickLoginBtn(GameObject go) 
    {
        C2SLogin c2slogin = new C2SLogin();
        c2slogin.account = "Z10002";
        c2slogin.password = "12345";
        ActionParam actionParam = new ActionParam(c2slogin);
        Net.Instance.Send((int)ActionType.Login, LoginCallback, actionParam, true);
    }

    void OnClickChatBtn(GameObject go) 
    {
        C2SChat requestPack = new C2SChat();
        requestPack.privatePlayerId = 1380002;
        requestPack.msgContent = "nihao";
        ActionParam actionParam = new ActionParam(requestPack);
        Net.Instance.Send((int)ActionType.Chat, null, actionParam, true);
    }

    void LoginCallback(ActionResult actionResult)
    {
        if (actionResult != null)
        {
            S2CLogin data = actionResult.GetValue<S2CLogin>();
            NetWriter.setSessionID(data.sessionId);
            NetWriter.setUserID(data.userId);
            if (data != null) 
            {
                Debug.Log("UserId:" + data.userId + " FirstLogin:" + data.isFirstLogin);
            }
        }
    }

    void ChatCallback(ActionResult actionResult) 
    {
        if (this != null && mChatMsg != null && actionResult != null) 
        {
            S2CChatCommonMsg msg = actionResult.GetValue<S2CChatCommonMsg>();
            if(msg != null)
            {
                mChatMsg.text = msg.charMsgInfo[0].msgContent;

                Debug.Log("sendtime:" + msg.charMsgInfo[0].sendTime + ":nowtime:" + System.DateTime.Now.Ticks);
            }
        }
    }
}
