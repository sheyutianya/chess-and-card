using System;
using System.Collections.Generic;
using UnityEngine;

public class Action1009 : BaseAction
{
    private ActionResult actionResult;

    public Action1009()
        : base((int)ActionType.GetRes)
    {
    }

    protected override void SendParameter(NetWriter writer, ActionParam actionParam)
    {
        //default url param
        writer.writeString("url", actionParam.Get<string>("url"));
    }

    protected override void DecodePackage(NetReader reader)
    {
        if (!reader.Success)
        {
            Debug.LogError(string.Format("Action {0} error {1}-{2}", reader.ActionId, reader.StatusCode, reader.Description));
            return;
        }
        actionResult = new ActionResult();
        //默认Scut流格式解包
        //actionResult["RoleID"] = reader.getInt();
        //GameSetting.Instance.RoleName = actionResult.Get<string>("RoleName");
    }

    public override ActionResult GetResponseData()
    {
        return actionResult;
    }
}
