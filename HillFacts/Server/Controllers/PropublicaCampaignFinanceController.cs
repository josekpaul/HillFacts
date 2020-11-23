using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Propublica.CampaignFinance.Api;
using Propublica.CampaignFinance.Api.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HillFacts.Server.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class PropublicaCampaignFinanceController : Controller
    {
        ApiClient _propublica;

        public PropublicaCampaignFinanceController(IOptions<HillFactsConfig> config, IMapper mapper)
        {
            _propublica = new ApiClient(config.Value.PropublicaApiKey);
        }

        public async Task<CandidateSearchResponse> SearchCandidate(string cycle, string query)
        {
            var result = await _propublica.SearchCandidates(cycle, query);
            return result;
        }

        public async Task<CandidateResponse> GetCandidate(string cycle, string fecId)
        {
            var result = await _propublica.GetCandidate(cycle, fecId);
            return result;
        }

        public async Task<IndependentExpenditurePerCandidateResponse> GetIndependentExpenditure(string cycle, string fecId)
        {
            var result = await _propublica.GetindependentExpenditurePerCandidate(cycle, fecId);
            return result;
        }

    }
}
