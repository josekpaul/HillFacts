
using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberCommittee
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string CommitteeUrl { get; set; }

        public int? RankInParty { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}