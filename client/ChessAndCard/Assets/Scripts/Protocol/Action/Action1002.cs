using System;
using System.Collections.Generic;
using Game.Pack;
using ZyGames.Framework.Common.Serialization;
using GameP;

public class Action1002 : BaseAction//GameAction
{
    private S2CChatCommonMsg mResponseData;
    private bool isCustom;

    public Action1002()
        : base((int)ActionType.Chat)
    {
    }

    protected override void SendParameter(NetWriter writer, ActionParam actionParam)
    {
        if (actionParam.HasValue)
        {
            ////自定对象参数格式
            isCustom = true;
            C2SChat requestPack = actionParam.GetValue<C2SChat>();
            //requestPack.privatePlayerId = 1380002;
            //requestPack.msgContent = "nihao";
            byte[] data = ProtoBufUtils.Serialize(requestPack);
            writer.SetBodyData(data);
        }
        else
        {
            isCustom = false;
            //默认url参数格式
            actionParam.Foreach((k, v) =>
            {
                writer.writeString(k, v.ToString());
                return true;
            });
        }
    }

    protected override void DecodePackage(NetReader reader)
    {
        if (reader != null && reader.StatusCode == 0)
        {
            //if (isCustom)
            //{
                //自定对象格式解包
                mResponseData = ProtoBufUtils.Deserialize<S2CChatCommonMsg>(reader.Buffer);
            //}
            //else
            //{
            //}
        }
    }

    public override ActionResult GetResponseData()
    {
        if (mResponseData != null)
        {

        }
        return new ActionResult(mResponseData);
    }
}
