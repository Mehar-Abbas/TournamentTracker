using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represents ONE team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as the winner (one level back)
        /// </summary>
        public MatchUpModel ParentMatchUp { get; set; }
    }
}
