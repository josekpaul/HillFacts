using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificCommitteeMember
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string MemberName { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("rank_in_party")]
        public string RankInParty { get; set; }

        [JsonProperty("begin_date")]
        public string DateStarted { get; set; }

        [JsonProperty("end_date")]
        public string DateEnded { get; set; }
    }
}