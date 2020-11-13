using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class Amendment
    {
        [JsonProperty("amendment_number")]
        public string Number { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor")]
        public string Sponsor { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUrl { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("introduced_date")]
        public string DateIntroduced { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string DateLatestMajorAction { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }
}
