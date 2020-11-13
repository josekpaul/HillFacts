using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RollCallVoteSummaryDemocratic
    {
        [JsonProperty("yes")]
        public int YesCount { get; set; }

        [JsonProperty("no")]
        public int NoCount { get; set; }

        [JsonProperty("present")]
        public int PresentVoterCount { get; set; }

        [JsonProperty("not_voting")]
        public int NotVotingCount { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }
}