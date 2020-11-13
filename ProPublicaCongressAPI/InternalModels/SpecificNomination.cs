using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificNomination
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("id")]
        public string NominationId { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("nominee_state")]
        public string NomineeState { get; set; }

        [JsonProperty("committee_url")]
        public string CommitteeDetailUrl { get; set; }

        [JsonProperty("latest_action_date")]
        public string DateLatestAction { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("actions")]
        public IReadOnlyCollection<SpecificNominationAction> Actions { get; set; }

        [JsonProperty("votes")]
        public IReadOnlyCollection<SpecificNominationVote> Votes { get; set; }
    }
}