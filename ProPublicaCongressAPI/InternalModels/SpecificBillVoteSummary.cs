using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificBillVoteSummary
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("date")]
        public string DateVoted { get; set; }

        [JsonProperty("time")]
        public string TimeVoted { get; set; }

        [JsonProperty("roll_call")]
        public int RollCallNumber { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("total_yes")]
        public int TotalYesVoteCount { get; set; }

        [JsonProperty("total_no")]
        public int TotalNoVoteCount { get; set; }

        [JsonProperty("total_not_voting")]
        public int TotalNotVotingCount { get; set; }

        [JsonProperty("api_url")]
        public string VoteDetailUrl { get; set; }
    }
}