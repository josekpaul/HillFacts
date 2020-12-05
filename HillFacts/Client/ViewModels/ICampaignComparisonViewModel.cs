using Propublica.CampaignFinance.Api.Contracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public interface ICampaignComparisonViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;

        Dictionary<string, string> Candidates { get; set; }
        List<CandidateResponse> CandidatesInfo { get; set; }
        DataTable CandidatesInfoTable { get; set; }

        Task GetInfo();
    }
}