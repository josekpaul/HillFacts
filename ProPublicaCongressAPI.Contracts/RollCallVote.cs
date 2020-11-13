using System;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class RollCallVote
    {
        public int Congress { get; set; }

        public Session Session { get; set; }

        public Chamber Chamber { get; set; }

        public int RollCallNumber { get; set; }
        
        public string Source { get; set; }
        
        public string Url { get; set; }

        public VoteBill Bill { get; set; }

        public VoteNomination Nomination { get; set; }

        public string Question { get; set; }

        public string Description { get; set; }

        public string VoteType { get; set; }

        public DateTime DateTimeRollCall { get; set; }

        public string Result { get; set; }

        public string TieBreaker { get; set; }

        public string TieBreakerVote { get; set; }

        public string DocumentNumber { get; set; }

        public string DocumentTitle { get; set; }

        public RollCallVoteSummaryDemocratic DemocraticVoteSummary { get; set; }

        public RollCallVoteSummaryRepublican RepublicanVoteSummary { get; set; }

        public RollCallVoteSummaryIndependent IndependentVoteSummary { get; set; }

        public RollCallVoteSummaryTotal TotalVoteSummary { get; set; }

        public IReadOnlyCollection<RollCallVotePosition> VotePositions { get; set; }
    }
}