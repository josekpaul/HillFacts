using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberVoteComparison
    {
        [JsonProperty("first_member_id")]
        public string FirstMemberId { get; set; }

        [JsonProperty("first_member_api_uri")]
        public string FirstMemberDetailUrl { get; set; }

        [JsonProperty("second_member_id")]
        public string SecondMemberId { get; set; }

        [JsonProperty("second_member_api_uri")]
        public string SecondMemberDetailUrl { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("common_votes")]
        public int AgreeVoteCount { get; set; }

        [JsonProperty("disagree_votes")]
        public int DisagreeVoteCount { get; set; }

        [JsonProperty("agree_percent")]
        public double AgreeVotePercent { get; set; }

        [JsonProperty("disagree_percent")]
        public double DisagreeVotePercent { get; set; }
    }
}