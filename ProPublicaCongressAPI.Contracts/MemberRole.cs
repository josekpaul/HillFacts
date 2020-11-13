
using System;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberRole
    {
        public int Congress { get; set; }

        public string Chamber { get; set; }

        public string Title { get; set; }

        public string State { get; set; }

        public string Party { get; set; }

        public string FecCandidateId { get; set; }

        public int Seniority { get; set; }

        public string District { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int BillSponsoredCount { get; set; }

        public int BillCosponsoredCount { get; set; }

        public double MissedVotesPercentage { get; set; }

        public double VotesWithPartyPercentage { get; set; }

        public IReadOnlyCollection<MemberCommittee> Committees { get; set; }
    }
}