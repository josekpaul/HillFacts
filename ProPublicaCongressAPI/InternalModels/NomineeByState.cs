using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class NomineeByState
    {
        [JsonProperty("id")]
        public string NomineeId { get; set; }

        [JsonProperty("uri")]
        public string NomineeDetailUrl { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("nominee_state")]
        public string NomineeState { get; set; }

        [JsonProperty("latest_action_date")]
        public string DateLatestAction { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}