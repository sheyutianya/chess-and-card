using System;
using System.Collections.Generic;
using System.IO;
using ZyGames.Framework.Game.Lang;
using ZyGames.Framework.Game.Service;

namespace GameServer.CsScript.Action
{
    public class Action1009 : BaseStruct
    {
        private string Url = string.Empty;
        private int Len;
        private byte[] Bytes;

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
            httpGet.GetString("url", ref Url);
            return true;
        }

        string AssetPath
        {
            get
            {
                string exePath = Environment.CurrentDirectory;
                exePath = exePath.Replace('\\', '/');
                exePath = exePath.Substring(0, exePath.IndexOf("/GameServer/"));
                return exePath + "/StreamingAssets/";
            }
        }

        /// <summary>
        /// 业务逻辑处理
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool TakeAction()
        {
            try
            {
                //string host = "http://127.0.0.1:6688/Service.aspx/";
                //string url = Url.ToString().Remove(0, host.Length - 1);
                string filename = AssetPath + Url;
                if (File.Exists(filename))
                {
                    using (Stream fs = File.Open(filename, FileMode.Open))
                    {
                        Len = (int)fs.Length;
                        Bytes = new byte[Len];
                        fs.Read(Bytes, 0, Len);
                        fs.Close();
                    }
                }

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
            //PushIntoStack(Len);
            PushIntoStack(Bytes);
        }
    }
}
