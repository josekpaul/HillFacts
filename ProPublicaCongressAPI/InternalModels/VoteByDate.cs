using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class VoteByDate
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("session")]
        public int Session { get; set; }

        [JsonProperty("roll_call")]
        public int RollCallNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("vote_uri")]
        public string VoteDetailUrl { get; set; }

        [JsonProperty("bill")]
        public VoteBill Bill { get; set; }

        [JsonProperty("nomination")]
        public VoteNomination Nomination { get; set; }

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

        [JsonProperty("tie_breaker")]
        public string TieBreaker { get; set; }

        [JsonProperty("tie_breaker_vote")]
        public string TieBreakerVote { get; set; }

        [JsonProperty("document_number")]
        public string DocumentNumber { get; set; }

        [JsonProperty("document_title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

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