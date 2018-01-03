using System;
using System.Collections.Generic;

using GameP;
using ZyGames.Framework.Game.Sns;
using ZyGames.Framework.Game.Sns.Service;
using ZyGames.Framework.Game.Lang;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Common;
using ZyGames.Framework.Common.Timing;
using ZyGames.Framework.Common.Serialization;
using GameServer.Script.Model;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Redis;

namespace GameServer.CsScript.Action
{

    public class MyLogin : ILogin
    {
        public MyLogin(string userName)
        {
            PassportID = userName;
            Password = string.Empty;
        }

        public string GetRegPassport()
        {
            return PassportID;
        }

        public bool CheckLogin()
        {
            var cacheSet = new PersonalCacheStruct<GameUser>();
            List<GameUser> gameuserlist = cacheSet.FindGlobal(t => t.PassportId == PassportID);
            if (gameuserlist != null && gameuserlist.Count > 0) 
            {
                UserID = gameuserlist[0].UserID;
                return true;
            }

            //GameUser gameuser = new GameUser
            //{
            //    UserId = RedisConnectionPool.GetNextNo(typeof(GameUser).FullName),
            //};

            //cacheSet.Add(gameuser);
            //cacheSet.Update();

            //var cache = new MemoryCacheStruct<ChatUser>();
            //ChatUser chatUser = cache.Find(t => t.UserName == PassportID);
            //if (chatUser != null)
            //{
            //    UserID = chatUser.UserId.ToString();
            //    return true;
            //}
            ////not user create it.
            //chatUser = new ChatUser()
            //{
            //    UserId = (int)RedisConnectionPool.GetNextNo(typeof(ChatUser).FullName),
            //    UserName = PassportID,
            //    AccessTime = DateTime.Now
            //};
            //if (cache.TryAdd(chatUser.UserId.ToString(), chatUser))
            //{
            //    UserID = chatUser.UserId.ToString();
            //    return true;
            //}
            return true;
        }

        public string PassportID { get; private set; }
        public string UserID { get; private set; }
        public int UserType { get; private set; }
        public string Password { get; set; }
        public string SessionID { get; private set; }
    }

    /// <summary>
    /// 登录
    /// </summary>
    /// <remarks>继续BaseStruct类:允许无身份认证的请求;AuthorizeAction:需要身份认证的请求</remarks>
    public class Action1001 : BaseAction
    {

        C2SLogin requestPack;
        S2CLogin responsePack;

        private string _userName;

        protected string PassportId = string.Empty;

        public Action1001(ActionGetter actionGetter)
            : base((short)1001, actionGetter)
        {

        }

        /// <summary>
        /// 客户端请求的参数较验
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool GetUrlElement()
        {
            byte[] data = (byte[])actionGetter.GetMessage();
            //使用protobuf反序列化
            //T t = ProtoBufUtils.Deserialize<T>(data);

            if (data.Length > 0)
            {
                requestPack = ProtoBufUtils.Deserialize<C2SLogin>(data);

                if (requestPack != null) 
                {
                    _userName = requestPack.account;
                }
                return true;
            }
            return false;
        }

        protected ILogin CreateLogin() 
        {
            return new MyLogin(_userName);
        }

        /// <summary>
        /// 业务逻辑处理
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool TakeAction()
        {
            ILogin login = CreateLogin();
            login.Password = DecodePassword(login.Password);
            var watch = RunTimeWatch.StartNew("Request login server");
            try
            {
                Sid = string.Empty;
                if (login.CheckLogin())
                {
                    watch.Check("GetResponse");
                    Current.SetExpired();
                    Current = GameSession.CreateNew(Guid.NewGuid());
                    Sid = Current.SessionId;

                    int userId = login.UserID.ToInt();

                    IUser user;
                    if (!GetError() && DoSuccess(userId, out user))
                    {
                        watch.Check("DoSuccess");
                        var session = GameSession.Get(Sid);
                        if (session != null)
                        {
                            //user is null in create role.
                            session.Bind(user ?? new SessionUser() { PassportId = PassportId, UserId = userId });
                            return true;
                        }
                    }
                }
                else 
                {
                    DoLoginFail(login);
                }
            }
            catch (HandlerException error)
            {
                ErrorCode = (int)error.StateCode;
                ErrorInfo = error.Message;
            }
            finally 
            {
                watch.Flush(true);
            }

            //在这里处理业务
            responsePack = new S2CLogin();
           
            return true;
        }

        /// <summary>
        /// 下发给客户的包结构数据
        /// </summary>
        protected override byte[] BuildResponsePack()
        {
            return ProtoBufUtils.Serialize(responsePack);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void DoLoginFail(ILogin login)
        {
            ErrorCode = Language.Instance.ErrorCode;
            ErrorInfo = Language.Instance.PasswordError;
        }

        ///// <summary>
        ///// Dos the success.
        ///// </summary>
        ///// <returns><c>true</c>, if success was done, <c>false</c> otherwise.</returns>
        ///// <param name="userId">User identifier.</param>
        ///// <param name="user"></param>
        //protected abstract bool DoSuccess(int userId, out IUser user);

        protected override bool DoSuccess(int userId, out IUser user)
        {
            //user = null;
            //var cache = new MemoryCacheStruct<GameUser>();
            //GameUser chatUser = cache.Find(t => t.UserName == _userName);
            //if (chatUser != null)
            //{
            //    user = chatUser;
            //    return true;
            //}
            return false;
        }

        protected override bool CreateUserRole(out IUser user)
        {
            user = null;
            GameUser userEntity = new PersonalCacheStruct<GameUser>().FindKey(UserId.ToString());

            if (new PersonalCacheStruct<GameUser>().FindKey(UserId.ToString()) == null)
            {
                userEntity = CreateGameUser();
                user = new SessionUser(userEntity);
            }
            else
            {
                return false;
            }
            return true;
        }


        private GameUser CreateGameUser()
        {
            GameUser userEntity = new GameUser
            {
                UserID = UserId.ToString(),
            };
            var cacheSet = new PersonalCacheStruct<GameUser>();
            cacheSet.Add(userEntity);
            cacheSet.Update();
            return userEntity;
        }

    }
}
