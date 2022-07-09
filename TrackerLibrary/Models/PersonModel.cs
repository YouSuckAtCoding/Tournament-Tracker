using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
   public class PersonModel
    {
        /// <summary>
        /// Represent the person name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represent the person last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the person email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the person phone number
        /// </summary>
        public string CellphoneNumber { get; set; }

    }
}
