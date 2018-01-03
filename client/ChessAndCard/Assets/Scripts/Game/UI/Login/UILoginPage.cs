﻿using System.Collections;
using System.Collections.Generic;
using UIFrameWork.UI;
using UnityEngine;
using UnityEngine.UI;

public class UILoginPage : TTUIPage
{

    GameObject m_login_btn;
    public UILoginPage()
        : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UI/panel/login/login_panel";
    }

    public override void Awake(GameObject go)
    {
        m_login_btn = this.transform.Find("btn_login").gameObject;
        m_login_btn.GetComponent<Button>().onClick.AddListener(delegate() 
        {
            OnClickLoginBtn(m_login_btn);
        });
    }

    void OnClickLoginBtn(GameObject go) 
    {
        LoginMsg.C2SLogin c2slogin = new LoginMsg.C2SLogin();
        ActionParam actionParam = new ActionParam(c2slogin);
        Net.Instance.Send((int)ActionType.Login, LoginCallback, actionParam, true);
    }

    void LoginCallback(ActionResult actionResult)
    {
        if (actionResult != null)
        {
        }
    }
}
