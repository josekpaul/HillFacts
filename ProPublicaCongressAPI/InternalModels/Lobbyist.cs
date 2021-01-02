using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.InternalModels
{


    public class Lobbyist
    {
        [JsonProperty("name")]

        public string name { get; set; }
        [JsonProperty("covered_position")]

        public string covered_position { get; set; }
    }
}
