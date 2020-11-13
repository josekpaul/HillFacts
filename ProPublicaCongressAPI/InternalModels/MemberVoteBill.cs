using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberVoteBill
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latest_action")]
        public string LatestAction { get; set; }
    }
}