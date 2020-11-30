using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
                treemap.Children = independentExpenditure.Results.GroupBy(r => r.CandidateName).Select(r => new TreemapInput
                {
                    Name = r.Key,
                    Children = new List<TreemapInput> { new TreemapInput { Name = "Support" , Children = new List<TreemapInput>()},
                        new TreemapInput { Name = "Oppose"  , Children = new List<TreemapInput>()} }.ToList()
                }).ToList();
                foreach(var result in independentExpenditure.Results)
                {
                    if (double.TryParse(result.Amount, out double amt))
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
                    else
                    {
                        string r = result.Amount;
                    }
                }
                var x = JsonSerializer.Serialize(treemap, new JsonSerializerOptions { WriteIndented = true });
                ExpenditureTreemapped = treemap;
                //ExpenditureTreemapped = JsonSerializer.Deserialize<TreemapInput>(@"{ ""Children"": [{ ""Name"": ""boss1"", ""Children"": [{ ""Name"": ""mister_a"", ""Group"": ""A"", ""Value"": 28, ""ColName"": ""level3"" }, { ""Name"": ""mister_b"", ""Group"": ""A"", ""Value"": 19, ""ColName"": ""level3"" }, { ""Name"": ""mister_c"", ""Group"": ""C"", ""Value"": 18, ""ColName"": ""level3"" }, { ""Name"": ""mister_d"", ""Group"": ""C"", ""Value"": 19, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }, { ""Name"": ""boss2"", ""Children"": [{ ""Name"": ""mister_e"", ""Group"": ""C"", ""Value"": 14, ""ColName"": ""level3"" }, { ""Name"": ""mister_f"", ""Group"": ""A"", ""Value"": 11, ""ColName"": ""level3"" }, { ""Name"": ""mister_g"", ""Group"": ""B"", ""Value"": 15, ""ColName"": ""level3"" }, { ""Name"": ""mister_h"", ""Group"": ""B"", ""Value"": 16, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }, { ""Name"": ""boss3"", ""Children"": [{ ""Name"": ""mister_i"", ""Group"": ""B"", ""Value"": 10, ""ColName"": ""level3"" }, { ""Name"": ""mister_j"", ""Group"": ""A"", ""Value"": 13, ""ColName"": ""level3"" }, { ""Name"": ""mister_k"", ""Group"": ""A"", ""Value"": 13, ""ColName"": ""level3"" }, { ""Name"": ""mister_l"", ""Group"": ""D"", ""Value"": 25, ""ColName"": ""level3"" }, { ""Name"": ""mister_m"", ""Group"": ""D"", ""Value"": 16, ""ColName"": ""level3"" }, { ""Name"": ""mister_n"", ""Group"": ""D"", ""Value"": 28, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }], ""Name"": ""CEO"" }");

            }
        }

    }
}
