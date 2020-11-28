using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D3Visualizations.Services;
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

        TreemapInput expenditureTreemapped;
        public TreemapInput ExpenditureTreemapped
        {
            get { return expenditureTreemapped; }
            set { SetValue<TreemapInput>(ref expenditureTreemapped, value); }
        }


        IndependentExpenditureResponse independentExpenditure;
        public IndependentExpenditureResponse IndependentExpenditure
        {
            get { return independentExpenditure; }
            set { SetValue<IndependentExpenditureResponse>(ref independentExpenditure, value); }
        }

        IAppCacheService cacheService;
        public CampFiCandidateViewModel(IAppCacheService cacheService)
        {
            this.cacheService = cacheService;
        }

        public async void GetCandidate()
        {
            Candidate = await cacheService.CallCacheableServerMethod<CandidateResponse>($"/api/PropublicaCampaignFinance/getcandidate?cycle={Cycle}&fecId={FecId}");
            IndependentExpenditure = await cacheService.CallCacheableServerMethod<IndependentExpenditureResponse>($"/api/PropublicaCampaignFinance/GetIndependentExpenditure?cycle={Cycle}");
            if (independentExpenditure.Results != null)
            {
                var treemap = new TreemapInput { Name = "Independent Expenditures"};
                treemap.Children = independentExpenditure.Results.Select(r => new TreemapInput
                {
                    Name = r.CandidateName,
                    Children = new List<TreemapInput> { new TreemapInput { Name = "Support" , Children = new List<TreemapInput>()},
                        new TreemapInput { Name = "Oppose"  , Children = new List<TreemapInput>()} }.ToList()
                }).ToList();
                foreach(var result in independentExpenditure.Results)
                {
                    if (int.TryParse(result.Amount, out int amt))
                    {
                        if (result.SupportOrOppose == "S")
                        {
                            treemap.Children.Where(c => c.Name == result.CandidateName).First().Children[0].Children.Add(new TreemapInput { Name = result.Payee, Value = amt });
                        }
                        else
                        {
                            treemap.Children.Where(c => c.Name == result.CandidateName).First().Children[1].Children.Add(new TreemapInput { Name = result.Payee, Value = amt });
                        }
                    }
                }
               ExpenditureTreemapped = treemap;
            }
        }

    }
}
