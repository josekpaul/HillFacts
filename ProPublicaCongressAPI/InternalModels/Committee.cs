using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class Committee
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string HomeUrl { get; set; }

        [JsonProperty("democratic_rss")]
        public string DemocratRssFeedUrl { get; set; }

        [JsonProperty("republican_rss")]
        public string RepublicanRssFeedUrl { get; set; }

        [JsonProperty("api_uri")]
        public string CommitteeDetailUrl { get; set; }

        [JsonProperty("chair")]
        public string ChairMemberName { get; set; }

        [JsonProperty("chair_id")]
        public string ChairMemberId { get; set; }

        [JsonProperty("chair_party")]
        public string ChairParty { get; set; }

        [JsonProperty("chair_state")]
        public string ChairState { get; set; }

        [JsonProperty("chair_uri")]
        public string ChairMemberDetailUrl { get; set; }

        [JsonProperty("ranking_member_id")]
        public string RankingMemberId { get; set; }
    }
}