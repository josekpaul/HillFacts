using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class VoteByTypeContainer
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public int NumberOfResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("members")]
        public IReadOnlyCollection<VoteByTypeMember> Members { get; set; }
    }
}