using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represent the place the price is related to
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represent the name of the place/position
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represent the percentage related to te priz
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
