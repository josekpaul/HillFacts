using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberBillSponsorshipComparisonContainer
    {
        [JsonProperty("first_member_api_uri")]
        public string FirstMemberDetailUrl { get; set; }

        [JsonProperty("second_member_api_uri")]
        public string SecondMemberDetailUrl { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("common_bills")]
        public int CommonBillCount { get; set; }

        [JsonProperty("bills")]
        public IReadOnlyCollection<MemberBillSponsorshipComparison> Bills { get; set; }
    }
}