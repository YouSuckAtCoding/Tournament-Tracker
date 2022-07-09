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
        /// Represent the prize unique identifier
        /// </summary>
        public int Id { get; set; }
        
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
        /// Represent the percentage related to te prize
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmoutValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmoutValue);
            PrizeAmount = prizeAmoutValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }

    }
}
