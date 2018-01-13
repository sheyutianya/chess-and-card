using GameP;
using GameServer.Script.Model;
using System;
using System.Collections.Generic;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common.Security;
using ZyGames.Framework.Common.Serialization;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Lang;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Game.Sns;
using ZyGames.Framework.Net;
using ZyGames.Framework.RPC.Sockets;

namespace GameServer.CsScript.Action
{
    public class Action1002 : BaseAction
    {
        C2SChat requestPack;
        S2CChatCommonMsg responsePack;

        ulong mToUserId;

        public Action1002(ActionGetter actionGetter)
            : base((short) ActionType.Chat, actionGetter)
        {
        }

        /// <summary>
        /// 客户端请求的参数较验
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool GetUrlElement()
        {
            byte[] data = (byte[])actionGetter.GetMessage();

            if (data.Length > 0)
            {
                requestPack = ProtoBufUtils.Deserialize<C2SChat>(data);

                if (requestPack != null)
                {
                    mToUserId = requestPack.privatePlayerId;
                }
                return true;
            }
            return false;
        }



        /// <summary>
        /// 业务逻辑处理
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool TakeAction()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                this.SaveLog(ex);
                this.ErrorCode = Language.Instance.ErrorCode;
                this.ErrorInfo = Language.Instance.St1002_GetRegisterPassportIDError;
                return false;
            }
        }

        public override void TakeActionAffter(bool state)
        {
            var user = PersonalCacheStruct.Get<GameUser>(mToUserId.ToString());

            List<ChatMsgInfo> msglist = new List<ChatMsgInfo>();

            ChatMsgInfo msginfo = new ChatMsgInfo();
            msginfo.messageId = "1aaaaaa";
            msginfo.msgContent = "aaaaa";
            msginfo.playerId = (ulong)Current.UserId;
            msginfo.sendTime = System.DateTime.Now.Ticks;

            responsePack = new S2CChatCommonMsg();
            responsePack.charMsgInfo.Add(msginfo);


            byte[] head = ProtoBufUtils.Serialize(new ResponsePack() { ActionId = 1002 });
            byte[] body = ProtoBufUtils.Serialize(responsePack);

            byte[] headBytes = BitConverter.GetBytes(head.Length);
            byte[] buffer = new byte[headBytes.Length + head.Length + body.Length];

            Buffer.BlockCopy(headBytes, 0, buffer, 0, headBytes.Length);
            Buffer.BlockCopy(head, 0, buffer, headBytes.Length, head.Length);
            Buffer.BlockCopy(body, 0, buffer, headBytes.Length + head.Length, body.Length);

            GameSession session = GameSession.Get((int)mToUserId);
            session.SendAsync(OpCode.Text, buffer, 0, buffer.Length, asyncResult =>
            {
                Console.WriteLine("Push Action -> {0} result is -> {1}", actionId, asyncResult.Result == ResultCode.Success ? "ok" : "fail");
            });


            base.TakeActionAffter(state);
        }

        /// <summary>
        /// 下发给客户的包结构数据
        /// </summary>
        public override void BuildPacket()
        {

        }

    }
}
