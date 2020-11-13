using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificBill
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("datetime")]
        public int Congress { get; set; }

        [JsonProperty("bill")]
        public string BillNumber { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("bill_uri")]
        public string BillDetailUrl { get; set; }

        [JsonProperty("title")]
        public string BillTitle { get; set; }

        [JsonProperty("short_title")]
        public string BillTitleShort { get; set; }

        [JsonProperty("sponsor")]
        public string SponsorMemberName { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorMemberDetailUrl { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public string BillDocumentPdfUrl { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressDotGovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovTrackUrl { get; set; }

        [JsonProperty("introduced_date")]
        public string DateIntroduced { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("house_passage")]
        public string DateHousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public string DateSenatePassage { get; set; }

        [JsonProperty("enacted")]
        public string Enacted { get; set; }

        [JsonProperty("vetoed")]
        public string Vetoed { get; set; }

        [JsonProperty("cosponsors")]
        public int CosponsorCount { get; set; }

        [JsonProperty("withdrawn_cosponsors")]
        public int WithdrawnCosponsorCount { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("committee_codes")]
        public string[] CommitteeCodes { get; set; }

        [JsonProperty("subcommittee_codes")]
        public string[] SubcommitteeCodes { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string DateLatestMajorAction { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("last_vote_date")]
        public string DateLastVote { get; set; }

        [JsonProperty("house_passage_vote")]
        public string DateHousePassageVote { get; set; }

        [JsonProperty("senate_passage_vote")]
        public string DateSenatePassageVote { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }

        [JsonProperty("actions")]
        public IReadOnlyCollection<SpecificBillAction> Actions { get; set; }

        [JsonProperty("votes")]
        public IReadOnlyCollection<SpecificBillVoteSummary> Votes { get; set; }
    }
}