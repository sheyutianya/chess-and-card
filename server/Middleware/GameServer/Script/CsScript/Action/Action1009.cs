using System;
using System.Collections.Generic;
using ZyGames.Framework.Game.Lang;
using ZyGames.Framework.Game.Service;

namespace GameServer.CsScript.Action
{
    public class Action1009 : BaseStruct
    {
        public Action1009(ActionGetter actionGetter)
            : base((short)ActionType.GetRes, actionGetter)
        {
        }


        /// <summary>
        /// 客户端请求的参数较验
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool GetUrlElement()
        {
            return true;
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
        /// <summary>
        /// 下发给客户的包结构数据
        /// </summary>
        public override void BuildPacket()
        {
            byte[] sss = new byte[2];
            sss[0] = 1;
            sss[1] = 2;
            PushIntoStack(2);
            //PushIntoStack(sss);
            //PushIntoStack(password);
        }
    }
}
