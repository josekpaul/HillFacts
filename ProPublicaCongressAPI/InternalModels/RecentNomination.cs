using Newtonsoft.Json;
using System;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RecentNomination
    {
        [JsonProperty("id")]
        public string NominationId { get; set; }

        [JsonProperty("uri")]
        public string NominationDetailUrl { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("nominee_state")]
        public string NomineeState { get; set; }

        [JsonProperty("committee_uri")]
        public string CommitteeDetailUrl { get; set; }

        [JsonProperty("latest_action_date")]
        public string DateLatestAction { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}