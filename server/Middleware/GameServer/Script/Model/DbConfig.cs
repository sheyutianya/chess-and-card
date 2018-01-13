using System.Configuration;

namespace GameServer.Script.Model 
{
    public class DbConfig
    {
        public const string Config = "ChessAndCardConfig";
        public const string Data = "ChessAndCardData";
        public const string Log = "ChessAndCardLog";

        public static string ConfigConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[Config].ConnectionString;
            }
        }

        public static string DataConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[Data].ConnectionString;
            }
        }

        public static string LogConnectString
        {
            get
            {   
                return ConfigurationManager.ConnectionStrings[Log].ConnectionString;
            }
        }

    }
}
