using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class RecentBill
    {
        public string BillId { get; set; }

        public string BillSlug { get; set; }

        public string BillType { get; set; }

        public string BillNumber { get; set; }

        public string BillDetailUrl { get; set; }

        public string BillTitle { get; set; }
        
        public string BillTitleShort { get; set; }

        public string SponsorId { get; set; }

        public string SponsorMemberDetailUrl { get; set; }

        public string BillDocumentPdfUrl { get; set; }

        public string CongressDotGovUrl { get; set; }

        public string GovTrackUrl { get; set; }

        public DateTime DateIntroduced { get; set; }

        public bool Active { get; set; }

        public DateTime? DateHousePassage { get; set; }

        public DateTime? DateSenatePassage { get; set; }
        
        public DateTime? Enacted { get; set; }

        public DateTime? Vetoed { get; set; }

        public int CosponsorCount { get; set; }

        public string Committees { get; set; }
        
        public string[] CommitteeCodes { get; set; }

        public string[] SubcommitteeCodes { get; set; }

        public string PrimarySubject { get; set; }

        public DateTime DateLatestMajorAction { get; set; }

        public string LatestMajorAction { get; set; }

        public string Summary { get; set; }

        public string SummaryShort { get; set; }
    }
}