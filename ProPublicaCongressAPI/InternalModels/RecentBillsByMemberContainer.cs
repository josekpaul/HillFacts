using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RecentBillsByMemberContainer
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("member_uri")]
        public string MemberDetailUrl { get; set; }

        [JsonProperty("name")]
        public string MemberName { get; set; }

        [JsonProperty("num_results")]
        public int NumberOfResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("bills")]
        public IReadOnlyCollection<RecentBillByMember> Bills { get; set; }
    }
}