using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class VoteByDateContainer
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("num_results")]
        public int NumberOfResults { get; set; }

        [JsonProperty("votes")]
        public IReadOnlyCollection<VoteByDate> Votes { get; set; }
    }
}