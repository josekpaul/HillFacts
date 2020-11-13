using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SenateNominationVoteContainer
    {
        [JsonProperty("total_votes")]
        public int TotalVotes { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("votes")]
        public IReadOnlyCollection<SenateNominationVote> Votes { get; set; }
    }
}