using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificBillDetailAmendment
    {
        public string AmendmentNumber { get; set; }

        public string SponsorMemberId { get; set; }

        public DateTime DateIntroduced { get; set; }

        public string Title { get; set; }

        public DateTime DateLatestMajorAction { get; set; }

        public string LatestMajorAction { get; set; }
    }
}