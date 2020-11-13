using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RecentBillByMember
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("number")]
        public string BillNumber { get; set; }

        [JsonProperty("bill_uri")]
        public string BillDetailUrl { get; set; }

        [JsonProperty("title")]
        public string BillTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorMemberId { get; set; }

        [JsonProperty("introduced_date")]
        public string DateIntroduced { get; set; }

        [JsonProperty("cosponsors")]
        public int CosponsorCount { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string DateLatestMajorAction { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }
}