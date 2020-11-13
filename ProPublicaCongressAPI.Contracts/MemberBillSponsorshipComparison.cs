using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberBillSponsorshipComparison
    {
        public string Number { get; set; }

        public string BillDetailUrl { get; set; }

        public string Title { get; set; }

        public string SponsorMemberDetailUrl { get; set; }

        public DateTime DateIntroduced { get; set; }

        public int CosponsorCount { get; set; }

        public string Committees { get; set; }

        public DateTime DateLatestMajorAction { get; set; }

        public string LatestMajorAction { get; set; }

        public DateTime DateFirstMember { get; set; }

        public DateTime DateSecondMember { get; set; }
    }
}