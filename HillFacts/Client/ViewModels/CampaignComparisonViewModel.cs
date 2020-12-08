using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using HillFacts.Client.Services;
using Propublica.CampaignFinance.Api.Contracts;

namespace HillFacts.Client.ViewModels
{
    public class CampaignComparisonViewModel : BaseViewModel, ICampaignComparisonViewModel
    {
        Dictionary<string, string> candidates;
        public Dictionary<string, string> Candidates
        {
            get { return candidates; }
            set { SetValue<Dictionary<string, string>>(ref candidates, value); }
        }

        List<CandidateResponse> candidatesInfo;
        public List<CandidateResponse> CandidatesInfo
        {
            get { return candidatesInfo; }
            set { SetValue<List<CandidateResponse>>(ref candidatesInfo, value); }
        }

        IAppCacheService appCacheService;
        public CampaignComparisonViewModel(IAppCacheService appCacheService)
        {
            this.appCacheService = appCacheService;
        }

        public async Task GetInfo()
        {
            var cInfo = new List<CandidateResponse>();
            foreach (var candidate in candidates)
            {
                var candidateInfo = await appCacheService.CallCacheableServerMethod<CandidateResponse>($"/api/PropublicaCampaignFinance/getcandidate?cycle=2020&fecId={candidate.Key}");
                cInfo.Add(candidateInfo);
            }
            CandidatesInfo = cInfo;
        }
    }
}
