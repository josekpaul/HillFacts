using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberVotesContainer
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("total_votes")]
        public int TotalVotes { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("votes")]
        public IReadOnlyCollection<MemberVote> Votes { get; set; }
    }
}