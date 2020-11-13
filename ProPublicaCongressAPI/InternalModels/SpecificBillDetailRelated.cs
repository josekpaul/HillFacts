using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificBillDetailRelated
    {
        [JsonProperty("bill")]
        public string BillNumber { get; set; }

        [JsonProperty("url_number")]
        public string BillUrlNumber { get; set; }

        [JsonProperty("title")]
        public string BillTitle { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("sponsor")]
        public string SponsorMemberName { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorMemberId { get; set; }

        [JsonProperty("introduced_date")]
        public string DateIntroduced { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string DateLatestMajorAction { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }
}