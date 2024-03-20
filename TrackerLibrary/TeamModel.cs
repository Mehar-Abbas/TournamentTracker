using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        // Represents the list of players in this particular team
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        // Represents this team's name
        public string TeamName { get; set; }
    }
}
