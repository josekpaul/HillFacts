using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificNominationVote
    {
        public string VoteDetailUrl { get; set; }
        public DateTime DateVote { get; set; }
        public int RollCallNumber { get; set; }
        public string Question { get; set; }
        public string Result { get; set; }
        public int TotalYesVoteCount { get; set; }
        public int TotalNoVoteCount { get; set; }
        public int TotalNotVotingCount { get; set; }
    }
}