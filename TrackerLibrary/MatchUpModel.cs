using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpModel
    {
        // Represents a list of teams playing this game - atleast a game having TWO teams
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();

        // Represents the winning team
        public TeamModel Winner { get; set; }

        // Represents the round number of this particular matchup
        public int MatchUpRound { get; set; }
    }
}
