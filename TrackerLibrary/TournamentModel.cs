using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        // Represents this tournament's name
        public string TournamentName { get; set; }

        // Represents the list of teams participating in this particular tournament
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
         
        // Represents the tournament's entre fee  
        public decimal EntryFee { get; set; }

        // Represents   st of prizes in this tournament
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
                  
        // Represents the rounds being played in this tournament - these are essentially multiple lists of matchups
        public List<List<MatchUpModel>> Rounds { get; set; } = new List<List<MatchUpModel>>();
    }
}
 