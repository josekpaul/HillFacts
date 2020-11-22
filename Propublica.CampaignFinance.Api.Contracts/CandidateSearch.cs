using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Propublica.CampaignFinance.Api.Contracts
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class CandidateSearchInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("party")]
        public string Party { get; set; }
    }

    public class CandidateSearchResult
    {
        [JsonPropertyName("candidate")]
        public CandidateSearchInfo Candidate { get; set; }

        [JsonPropertyName("committee")]
        public string Committee { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }
    }

    public class CandidateSearchResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("cycle")]
        public int Cycle { get; set; }

        [JsonPropertyName("base_uri")]
        public string BaseUri { get; set; }

        [JsonPropertyName("num_results")]
        public int NumResults { get; set; }

        [JsonPropertyName("offset")]
        public object Offset { get; set; }

        [JsonPropertyName("results")]
        public List<CandidateSearchResult> Results { get; set; }
    }

}
