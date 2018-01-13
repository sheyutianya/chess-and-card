using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Script.Logic
{
    class GameRoom
    {
        private static GameRoom mInstance;
        static GameRoom() 
        {

        }

        public static GameRoom Current 
        {
            get { return mInstance; }
        }
    }
}
