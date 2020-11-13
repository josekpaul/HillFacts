using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class AmendmentsContainer
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("num_results")]
        public int NumberOfResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amendments")]
        public IReadOnlyCollection<Amendment> Amendments { get; set; }
    }
}