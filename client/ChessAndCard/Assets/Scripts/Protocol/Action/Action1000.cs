using System;
using UnityEngine;
using ZyGames.Framework.Common.Serialization;
using Game.Pack;

public class Action1000 : BaseAction
{

    private bool isCustom;

    public Action1000()
        : base((int)ActionType.Login)
    {
    }

    protected override void SendParameter(NetWriter writer, ActionParam actionParam)
    {
        if (actionParam.HasValue)
        {
            //自定对象参数格式
            isCustom = true;
            var loginData = actionParam.GetValue<LoginMsg.C2SLogin>();
            byte[] data = ProtoBufUtils.Serialize(loginData);
            writer.SetBodyData(data);
        }
        else
        {
            isCustom = false;
            writer.writeString("UserName", "Jon");
            writer.writeInt32("Score", 100);
        }
    }

    protected override void DecodePackage(NetReader reader)
    {
        if (reader != null && reader.StatusCode == 0)
        {
            Debug.Log("1000 response ok.");
        }
    }

    public override ActionResult GetResponseData()
    {
        return null;
    }
}
