using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the total list of entries of this tournament.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner of this particular matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round of this particular matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
