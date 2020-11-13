using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class CurrentMember
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("times_topics_url")]
        public string TimesTopicsUrl { get; set; }

        [JsonProperty("twitter_id")]
        public string TwitterAccount { get; set; }

        [JsonProperty("youtube_id")]
        public string YouTubeAccount { get; set; }

        [JsonProperty("seniority")]
        public int Seniority { get; set; }

        [JsonProperty("next_election")]
        public int NextElectionYear { get; set; }

        [JsonProperty("api_url")]
        public string MemberDetailUrl { get; set; }

        [JsonProperty("district")]
        public int District { get; set; }
    }
}