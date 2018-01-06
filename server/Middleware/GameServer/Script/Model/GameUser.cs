/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/

using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Model;

namespace GameServer.Script.Model 
{
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary,"chessandcard")]
    public class GameUser : BaseUser
    {
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public String UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }

        private String _RetailID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("RetailID")]
        public String RetailID
        {
            get
            {
                return _RetailID;
            }
            set
            {
                SetChange("RetailID", value);
            }
        }
        private String _Pid;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("Pid")]
        public String Pid
        {
            get
            {
                return _Pid;
            }
            set
            {
                SetChange("Pid", value);
            }
        }

        private String _NickName;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("NickName")]
        public String NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                SetChange("NickName", value);
            }
        }

        private UserStatus _UserStatus;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("UserStatus")]
        public UserStatus UserStatus
        {
            get
            {
                return _UserStatus;
            }
            set
            {
                SetChange("UserStatus", value);
            }
        }

        private string _sessionID;
        public string SessionID
        {
            get { return _sessionID; }
            set
            {
                _sessionID = value;
            }
        }


        /// <summary>
        /// 对象索引器属性
        /// </summary>
        /// <returns></returns>
        /// <param name="index">Index.</param>
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "UserID": return UserID;
                    case "RetailID": return RetailID;
                    case "Pid": return Pid;
                    case "NickName": return NickName;
                    case "UserStatus": return UserStatus;                     
                    default: throw new ArgumentException(string.Format("GameUser index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "RetailID":
                        _RetailID = value.ToNotNullString();
                        break;
                    case "Pid":
                        _Pid = value.ToNotNullString();
                        break;
                    case "NickName":
                        _NickName = value.ToNotNullString();
                        break;
                    case "UserStatus":
                        _UserStatus = value.ToEnum<UserStatus>();
                        break;
                    default: throw new ArgumentException(string.Format("GameUser index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }

        public override string GetNickName()
        {
            return NickName;
        }

        public override string GetPassportId()
        {
            return Pid;
        }

        public override string GetRetailId()
        {
            return RetailID;
        }

        public override int GetUserId()
        {
            return UserID.ToInt();
        }

        public override bool IsLock
        {
            get { return UserStatus == UserStatus.FengJin; }
        }

 
    }

}