
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class SenateNominationVoteContainer
    {
        public int TotalVotes { get; set; }
        
        public int Offset { get; set; }
        
        public IReadOnlyCollection<SenateNominationVote> Votes { get; set; }
    }
}