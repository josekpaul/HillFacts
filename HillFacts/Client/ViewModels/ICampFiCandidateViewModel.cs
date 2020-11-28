using D3Visualizations.Services;
using Propublica.CampaignFinance.Api.Contracts;
using System.ComponentModel;

namespace HillFacts.Client.ViewModels
{
    public interface ICampFiCandidateViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;
        CandidateResponse Candidate { get; set; }
        string Cycle { get; set; }
        string FecId { get; set; }
        TreemapInput ExpenditureTreemapped { get; set; }
        void GetCandidate();
    }
}