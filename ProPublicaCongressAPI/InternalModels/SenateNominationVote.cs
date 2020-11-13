using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SenateNominationVote
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("session")]
        public int Session { get; set; }

        [JsonProperty("roll_call")]
        public int RollCallNumber { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vote_type")]
        public string VoteType { get; set; }

        [JsonProperty("date")]
        public string DateVoted { get; set; }

        [JsonProperty("time")]
        public string TimeVoted { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("nominee_uri")]
        public string NomineeDetailUrl { get; set; }

        [JsonProperty("democratic")]
        public RollCallVoteSummaryDemocratic DemocraticVoteSummary { get; set; }

        [JsonProperty("republican")]
        public RollCallVoteSummaryRepublican RepublicanVoteSummary { get; set; }

        [JsonProperty("independent")]
        public RollCallVoteSummaryIndependent IndependentVoteSummary { get; set; }

        [JsonProperty("total")]
        public RollCallVoteSummaryTotal TotalVoteSummary { get; set; }
    }
}