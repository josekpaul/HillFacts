using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class VoteNomination
    {
        [JsonProperty("nomination_id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }
    }
}
