using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HillFacts.Client.Services;
using Propublica.CampaignFinance.Api;
using Propublica.CampaignFinance.Api.Contracts;

namespace HillFacts.Client.ViewModels
{
    public class CampFiCandidateViewModel : BaseViewModel, ICampFiCandidateViewModel
    {
        string fecId;
        public string FecId
        {
            get { return fecId; }
            set { SetValue<string>(ref fecId, value); }
        }

        string cycle;
        public string Cycle
        {
            get { return cycle; }
            set { SetValue<string>(ref cycle, value); }
        }

        CandidateResponse candidate;
        public CandidateResponse Candidate
        {
            get { return candidate; }
            set { SetValue<CandidateResponse>(ref candidate, value); }
        }

        IAppCacheService cacheService;
        public CampFiCandidateViewModel(IAppCacheService cacheService)
        {
            this.cacheService = cacheService;
        }

        public async void GetCandidate()
        {
            Candidate = await cacheService.CallCacheableServerMethod<CandidateResponse>($"/api/PropublicaCampaignFinance/getcandidate?cycle={Cycle}&fecId={FecId}");
        }

    }
}
