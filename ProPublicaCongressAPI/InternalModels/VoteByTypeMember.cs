using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class VoteByTypeMember
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string MemberName { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("total_votes")]
        public int? TotalVoteCount { get; set; }

        [JsonProperty("votes_with_party")]
        public int? VotesWithPartyCount { get; set; }

        [JsonProperty("party_votes_pct")]
        public double? VotesWithPartyPercent { get; set; }

        [JsonProperty("missed_votes")]
        public int? VotesMissedCount { get; set; }

        [JsonProperty("missed_votes_pct")]
        public double? VotesMissedPercent { get; set; }

        [JsonProperty("loneno")]
        public int? VotesLoneNoCount { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}