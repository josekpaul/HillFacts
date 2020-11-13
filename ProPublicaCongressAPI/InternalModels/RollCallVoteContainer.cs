using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RollCallVoteContainer
    {
        [JsonProperty("vote")]
        public RollCallVote Vote { get; set; }
    }
}