using System;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class BillCosponsorContainer
    {
        public int Congress { get; set; }
        public string BillNumber { get; set; }
        public string BillUrlNumber { get; set; }
        public string BillTitle { get; set; }
        public string SponsorMemberName { get; set; }
        public string SponsorMemberId { get; set; }
        public DateTime DateIntroduced { get; set; }
        public int CosponsorCount { get; set; }
        public string Committees { get; set; }
        public DateTime DateLatestMajorAction { get; set; }
        public string LatestMajorAction { get; set; }
        public DateTime? DateHousePassageVote { get; set; }
        public DateTime? DateSenatePassageVote { get; set; }
        public IReadOnlyCollection<BillCosponsorPartySummary> PartySummaries { get; set; }
        public IReadOnlyCollection<BillCosponsor> Cosponsors { get; set; }
    }
}