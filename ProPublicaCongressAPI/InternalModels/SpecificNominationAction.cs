using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificNominationAction
    {
        [JsonProperty("date")]
        public string DateAction { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}