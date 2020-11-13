
using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificBillDetailRelated
    {
        public string BillNumber { get; set; }
        public string BillUrlNumber { get; set; }
        public string BillTitle { get; set; }
        public string Relationship { get; set; }
        public string SponsorMemberName { get; set; }
        public string SponsorMemberId { get; set; }
        public DateTime DateIntroduced { get; set; }
        public DateTime DateLatestMajorAction { get; set; }
        public string LatestMajorAction { get; set; }
    }
}