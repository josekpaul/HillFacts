using Propublica.CampaignFinance.Api.Contracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public interface ICampaignComparisonViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;

        Dictionary<string, string> Candidates { get; set; }
        List<CandidateResponse> CandidatesInfo { get; set; }

        Task GetInfo();
    }
}