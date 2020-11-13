using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RollCallVoteSummaryIndependent
    {
        [JsonProperty("yes")]
        public int YesCount { get; set; }

        [JsonProperty("no")]
        public int NoCount { get; set; }

        [JsonProperty("present")]
        public int PresentVoterCount { get; set; }

        [JsonProperty("not_voting")]
        public int NotVotingCount { get; set; }
    }
}