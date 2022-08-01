using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents all of the team members for this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        
        /// <summary>
        /// Represents the team name for this team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
