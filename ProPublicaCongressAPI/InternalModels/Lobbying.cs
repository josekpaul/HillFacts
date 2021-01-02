using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.InternalModels
{
    public class Result
    {
        [JsonProperty("lobbying_representations")]

        public List<LobbyingRepresentation> lobbying_representations { get; set; }
    }
}
