using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class NewMembersContainer
    {
        [JsonProperty("num_results")]
        public int NumberOfResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("members")]
        public IReadOnlyCollection<NewMember> Members { get; set; }
    }
}