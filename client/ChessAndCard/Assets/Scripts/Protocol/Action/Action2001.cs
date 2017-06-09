using System;
using UnityEngine;

public class Action2001 : GameAction
{
    private ActionResult actionResult;

    public Action2001()
        : base(2001)
    {
    }

    protected override void SendParameter(NetWriter writer, ActionParam actionParam)
    {
        writer.writeString("UserName", actionParam.Get<string>("userName"));
        writer.writeInt32("UserId", actionParam.Get<int>("userId"));
    }

    protected override void DecodePackage(NetReader reader)
    {
        actionResult = new ActionResult();
        actionResult["RoleId"] = reader.getInt();
        actionResult["UserId"] = reader.getInt();
        actionResult["RoleName"] = reader.readString();

    }

    public override ActionResult GetResponseData()
    {
        return actionResult;
    }
}
