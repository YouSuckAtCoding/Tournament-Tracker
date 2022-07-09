using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interface;

namespace TrackerLibrary.Connection
{
    public static class GlobalConfig
    {
        //list of "interface" means that it will hold anything that implements the interface
        public static List<IDataConnection> connections { get; private set; } = new List<IDataConnection>();
        
        public static void InitializeConnection(bool database, bool textfile)
        {
            if (database)
            {
                // TODO - Setup sqlConnector properly
                SQLConnector sql = new SQLConnector();
                connections.Add(sql);
            }
            if(textfile)
            {
                // TODO - Setup Text Connector properly
                TextConnector text = new TextConnector();
                connections.Add(text);
            }
        }
    }
}
