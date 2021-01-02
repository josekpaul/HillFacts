using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.InternalModels
{
    public class LatestFiling
    {
        [JsonProperty("filing_date")]
        public string filing_date { get; set; }
        [JsonProperty("report_year")]
        public string report_year { get; set; }
        [JsonProperty("report_type")]
        public string report_type { get; set; }
        [JsonProperty("pdf_url")]
        public string pdf_url { get; set; }
    }
}
