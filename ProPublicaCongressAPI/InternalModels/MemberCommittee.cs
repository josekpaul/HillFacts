using Newtonsoft.Json;
using System;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberCommittee
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("api_uri")]
        public string CommitteeUrl { get; set; }

        [JsonProperty("rank_in_party")]
        public int? RankInParty { get; set; }

        [JsonProperty("begin_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }
    }
}