using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.InternalModels
{
    public class LobbyingRepresentation
    {
        [JsonProperty("lobbying_client")]
        public LobbyingClient lobbying_client { get; set; }
        [JsonProperty("lobbying_registrant")]
        public LobbyingRegistrant lobbying_registrant { get; set; }
        [JsonProperty("inhouse")]
        public string inhouse { get; set; }
        [JsonProperty("signed_date")]
        public string signed_date { get; set; }
        [JsonProperty("effective_date")]
        public string effective_date { get; set; }
        [JsonProperty("xml_filename")]
        public string xml_filename { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("specific_issues")]
        public List<string> specific_issues { get; set; }
        [JsonProperty("report_type")]
        public string report_type { get; set; }
        [JsonProperty("report_year")]
        public string report_year { get; set; }
        [JsonProperty("senate_id")]
        public string senate_id { get; set; }
        [JsonProperty("house_id")]
        public string house_id { get; set; }
        [JsonProperty("latest_filing")]
        public LatestFiling latest_filing { get; set; }
        [JsonProperty("lobbyists")]
        public List<Lobbyist> lobbyists { get; set; }
    }
}
