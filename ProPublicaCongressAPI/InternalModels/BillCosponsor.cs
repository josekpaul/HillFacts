using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class BillCosponsor
    {
        [JsonProperty("cosponsor_id")]
        public string CosponsorMemberId { get; set; }

        [JsonProperty("name")]
        public string CosponsorMemberName { get; set; }

        [JsonProperty("date")]
        public string DateCosponsored { get; set; }
    }
}