using System;
using ZyGames.Framework.Common.Security;
using ZyGames.Framework.Game.Lang;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Game.Sns;

namespace GameServer.CsScript.Action
{
    public class Action1000 :BaseStruct
    {
        private string UserName;
        private int Score;


        public Action1000(HttpGet httpGet)
            : base(1000, httpGet)
        {
        }

        public override void BuildPacket()
        {

        }

        public override bool GetUrlElement()
        {
            if (httpGet.GetString("UserName", ref UserName)
                 && httpGet.GetInt("Score", ref Score))
            {
                return true;
            }
            return false;
        }

        public override bool TakeAction()
        {
            var cache = new ShareCacheStruct<UserRanking>();
            var ranking = cache.Find(m => m.UserName == UserName);
            if (ranking == null)
            {
                var user = new GameUser() { UserId = (int)cache.GetNextNo(), NickName = UserName};
                new PersonalCacheStruct<GameUser>().Add(user);
                ranking = new UserRanking();
                ranking.UserID = user.UserId;
                ranking.UserName = UserName;
                ranking.Score = Score;
                cache.Add(ranking);
            }
            else
            {
                ranking.UserName = UserName;
                ranking.Score = Score;
            }
            return true;
        }

    }
}