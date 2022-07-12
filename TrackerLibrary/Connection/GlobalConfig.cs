using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Connectors;
using TrackerLibrary.Enum;
using TrackerLibrary.Interface;


namespace TrackerLibrary.Connection
{
    public static class GlobalConfig
    {
        //list of "interface" means that it will hold anything that implements the interface
        
        public static IDataConnection Connection { get; private set; }
        
        public static void InitializeConnection(DatabaseType db)
        {

            
            if (db == DatabaseType.Sql)
            {
                // TODO - Setup sqlConnector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                // TODO - Setup Text Connector properly
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
