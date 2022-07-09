using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interface;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Make the create prize method save to the database.
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">Prize information</param>
        /// <returns>The prize information + the id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            
            return model;
        }
    }
}
