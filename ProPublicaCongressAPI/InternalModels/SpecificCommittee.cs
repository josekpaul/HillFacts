using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificCommittee
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("committee")]
        public string CommitteeName { get; set; }

        [JsonProperty("num_results")]
        public int NumberOfResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("chairman_id")]
        public string ChairmanMemberId { get; set; }

        [JsonProperty("ranking_member_id")]
        public string RankingMemberId { get; set; }

        [JsonProperty("democratic_rss")]
        public string DemocratRssFeedUrl { get; set; }

        [JsonProperty("republican_rss")]
        public string RepublicaRssFeedUrl { get; set; }

        [JsonProperty("current_members")]
        public IReadOnlyCollection<SpecificCommitteeMember> CurrentMembers { get; set; }

        [JsonProperty("former_members")]
        public IReadOnlyCollection<SpecificCommitteeMember> FormerMembers { get; set; }
    }
}