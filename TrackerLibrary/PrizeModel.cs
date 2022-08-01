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
        /// Represents the required placement for this prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the placement for this prize.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount for this prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of this prize to total amount.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
