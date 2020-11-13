using Newtonsoft.Json;
using System;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificNominationVote
    {
        [JsonProperty("uri")]
        public string VoteDetailUrl { get; set; }

        [JsonProperty("date")]
        public string DateVote { get; set; }

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
    }
}