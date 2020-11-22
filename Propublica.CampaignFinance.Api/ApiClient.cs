using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Propublica.CampaignFinance.Api.Contracts;

namespace Propublica.CampaignFinance.Api
{
    public class ApiClient
    {
        private readonly string apiKey;

        private const string apiBaseUrl = "https://api.propublica.org/campaign-finance/";
        private const string independentExpenditurePerCandidateUrl = "v1/{0}/candidates/{1}/independent_expenditures";
        private const string candidateSearchUrl = "v1/{0}/candidates/search?query={1}";
        private const string candidateUrl = "v1/{0}/candidates/{1}";

        public ApiClient(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<CandidateSearchResponse> SearchCandidates(string cycle, string query)
        {
            var url = string.Format(candidateSearchUrl, cycle, query);
            var response = await GetData<CandidateSearchResponse>(url);
            return response;
        }

        public async Task<CandidateResponse> GetCandidate(string cycle, string fecId)
        {
            var url = string.Format(candidateUrl, cycle, fecId);
            var response = await GetData<CandidateResponse>(url);
            return response;
        }

        public async Task<IndependentExpenditurePerCandidateResponse> GetindependentExpenditurePerCandidate(string cycle, string fecId)
        {
            var url = string.Format(independentExpenditurePerCandidateUrl, cycle, fecId);
            var response = await GetData<IndependentExpenditurePerCandidateResponse>(url);
            return response;
        }


        private async Task<T> GetData<T>(string relativeurl, string baseUrl = apiBaseUrl)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
            var json = await httpClient.GetStringAsync(baseUrl + relativeurl);
            var result = JsonSerializer.Deserialize<T>(json);
            return result;
        }
    }
}
