using Newtonsoft.Json;
using System;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class NewMember
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }
    }
}