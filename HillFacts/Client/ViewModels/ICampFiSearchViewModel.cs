using Propublica.CampaignFinance.Api.Contracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public interface ICampFiSearchViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;

        string Cycle { get; set; }
        string Query { get; set; }
        IEnumerable<CandidateSearchResult> SearchResults { get; set; }

        Task GetSearchResults();
    }
}