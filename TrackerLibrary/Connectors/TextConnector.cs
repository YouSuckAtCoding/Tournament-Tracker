using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interface;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the create prize method save to the text file
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
