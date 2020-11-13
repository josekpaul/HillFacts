using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class VoteBill
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("number")]
        public string BillNumber { get; set; }

        [JsonProperty("title")]
        public string BillTitle { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUrl { get; set; }        

        [JsonProperty("latest_action")]
        public string LatestAction { get; set; }
    }
}