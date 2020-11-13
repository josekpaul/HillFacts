using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RollCallVotesContainer
    {
        [JsonProperty("votes")]
        public RollCallVoteContainer Votes { get; set; }
    }
}