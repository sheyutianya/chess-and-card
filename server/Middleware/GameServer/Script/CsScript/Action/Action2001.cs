using GameServer.Script.Model;
using System;
using System.Collections.Generic;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Lang;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Model;


namespace GameServer.CsScript.Action
{
   
    /// <summary>
    /// 推送角色基础信息
    /// </summary>
    /// <remarks>继续BaseStruct类:允许无身份认证的请求;AuthorizeAction:需要身份认证的请求</remarks>
    public class Action2001 : BaseStruct
    {
        
        #region class object
        /// <summary>
        /// Main Body
        /// </summary>
        class ResponsePacket
        {
            /// <summary>
            /// 角色id
            /// </summary>
            public int RoleId { get; set; }
            /// <summary>
            /// UserId
            /// </summary>
            public int UserId { get; set; }
            /// <summary>
            /// RoleName
            /// </summary>
            public string RoleName { get; set; }
            
        }
        #endregion

        /// <summary>
        /// 响应数据包
        /// </summary>
        private ResponsePacket _packet = new ResponsePacket();

        /// <summary>
        /// UserName
        /// </summary>
        private string _userName;
        /// <summary>
        /// UserId
        /// </summary>
        private int _userId;

        public Action2001(ActionGetter actionGetter)
            : base((short)2001, actionGetter)
        {

        }

        /// <summary>
        /// 客户端请求的参数较验
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool GetUrlElement()
        {
            if (httpGet.GetString("UserName", ref _userName)
                && httpGet.GetInt("UserId", ref _userId))
            {
                //UserId = _userId;
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
            IUser user;
            if (CreateUserRole(out user) && Current != null && user != null)
            {
                Current.Bind(user);
                return true;
            }
            return false;
        }

        protected bool CreateUserRole(out IUser user)
        {
            user = null;
            if (_userName.Length < 2 || _userName.Length > 12)
            {
                ErrorCode = Language.Instance.ErrorCode;
                ErrorInfo = Language.Instance.St1005_UserNameNotEnough;
                return false;
            }
            var userCache = new PersonalCacheStruct<GameUser>();
            var roleCache = new PersonalCacheStruct<UserRole>();
            GameUser gameUser;
            if (userCache.TryFindKey(UserId.ToString(), out gameUser) == LoadingStatus.Success)
            {
                if (gameUser == null)
                {
                    gameUser = new GameUser
                    {
                        UserId = UserId,
                        //PassportId = Pid,
                        //RetailId = RetailID,
                        //NickName = Pid
                    };
                    userCache.Add(gameUser);
                }
                user = new SessionUser(gameUser);
                UserRole role;
                if (roleCache.TryFind(gameUser.PersonalId, r => r.RoleName == _userName, out role) == LoadingStatus.Success)
                {
                    if (role == null)
                    {
                        role = new UserRole()
                        {
                            RoleId = (int)roleCache.GetNextNo(),
                            UserId = UserId,
                            RoleName = _userName,
                            //HeadImg = HeadID,
                            //Sex = Sex.ToBool(),
                            LvNum = 1,
                            ExperienceNum = 0,
                            LifeNum = 100,
                            LifeMaxNum = 100
                        };
                        roleCache.Add(role);
                        gameUser.CurrRoleId = role.RoleId;
                    }

                    _packet.RoleId = role.RoleId;
                    _packet.UserId = role.UserId;
                    _packet.RoleName = role.RoleName;

                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 下发给客户的包结构数据
        /// </summary>
        public override void BuildPacket()
        {
            this.PushIntoStack(_packet.RoleId);
            this.PushIntoStack(_packet.UserId);
            this.PushIntoStack(_packet.RoleName);

        }

    }
}
