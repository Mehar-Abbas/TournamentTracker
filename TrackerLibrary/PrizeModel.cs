using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        // Represents the prize number e.g first place , second place and so on...
        public int PrizeNUmber { get; set; }

        // Represents the prize name e.g. first runner up, champion etc.
        public string PrizeName { get; set; }

        // Represents the amount of this prize
        public decimal PrizeAmount { get; set; }

        // Represents the percentage of the amount of the prize
        public double PrizePercentage { get; set; }
    }
}
