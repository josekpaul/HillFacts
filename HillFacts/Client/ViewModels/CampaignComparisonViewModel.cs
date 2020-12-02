using System;
using System.Collections.Generic;
using System.Data;
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

        DataTable candidatesInfoTable;
        public DataTable CandidatesInfoTable
        {
            get { return candidatesInfoTable; }
            set { SetValue<DataTable>(ref candidatesInfoTable, value); }
        }



        IAppCacheService appCacheService;
        public CampaignComparisonViewModel(IAppCacheService appCacheService)
        {
            this.appCacheService = appCacheService;
        }

        public async void GetInfo()
        {
            candidatesInfo = new List<CandidateResponse>();
            foreach (var candidate in candidates)
            {
                var candidateInfo = await appCacheService.CallCacheableServerMethod<CandidateResponse>($"/api/PropublicaCampaignFinance/getcandidate?cycle=2020&fecId={candidate.Key}");
                candidatesInfo.Add(candidateInfo);
            }
            OnPropertyChanged("CandidatesInfo");
            DataTable dt = new DataTable();
            dt.Columns.Add("Candidate");
            dt.Columns.Add("Total From Individuals (Itemized)");
            dt.Columns.Add("Total From Individuals (UnItemized)");
            dt.Columns.Add("Total From PACs");

            foreach (var c in candidatesInfo)
            {
                dt.Rows.Add(c.Results[0].DisplayName, Math.Round(c.Results[0].TotalFromIndividualsItemized/1000000.00, 2),
                    Math.Round(c.Results[0].TotalFromIndividualsUnitemized / 1000000.00, 2), Math.Round(c.Results[0].TotalFromPacs / 1000000.00, 2));
            }
            CandidatesInfoTable = dt;
        }
    }
}
