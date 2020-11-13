using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberVotesContainer
    {
        public string MemberId { get; set; }

        public int TotalVotes { get; set; }

        public int Offset { get; set; }

        public IReadOnlyCollection<MemberVote> Votes { get; set; }
    }
}