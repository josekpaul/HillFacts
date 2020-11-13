using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class BillCosponsorPartySummary
    {
        [JsonProperty("id")]
        public string PartyId { get; set; }

        [JsonProperty("sponsors")]
        public int SponsorCount { get; set; }
    }
}