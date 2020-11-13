using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificBillVoteSummary
    {
        public Chamber Chamber { get; set; }

        public DateTime DateTimeVoted { get; set; }

        public int RollCallNumber { get; set; }

        public string Question { get; set; }

        public string Result { get; set; }

        public int TotalYesVoteCount { get; set; }

        public int TotalNoVoteCount { get; set; }

        public int TotalNotVotingCount { get; set; }

        public string VoteDetailUrl { get; set; }
    }
}