using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI
{
    internal class ApiResponse<T>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public T Results { get; set; }
    }
}