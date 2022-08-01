using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {

        /// <summary>
        /// Represents the name of this tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee for this tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents all of the participating teams for this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
       
        /// <summary>
        /// Represents the decided prizes for this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
      
        /// <summary>
        /// Represents all of the rounds for this tournament with a list.
        /// Rounds contain a list of matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
