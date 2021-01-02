using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.InternalModels
{
    public class LobbyingClient
    {
        [JsonProperty("name")]

        public string name { get; set; }
        [JsonProperty("general_description")]

        public string general_description { get; set; }
    }
}
