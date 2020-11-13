using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberRole
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("seniority")]
        public int Seniority { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("bills_sponsored")]
        public int BillSponsoredCount { get; set; }

        [JsonProperty("bills_cosponsored")]
        public int BillCosponsoredCount { get; set; }

        [JsonProperty("missed_votes_pct")]
        public double MissedVotesPercentage { get; set; }

        [JsonProperty("votes_with_party_pct")]
        public double VotesWithPartyPercentage { get; set; }

        [JsonProperty("committees")]
        public IReadOnlyCollection<MemberCommittee> Committees { get; set; }
    }
}