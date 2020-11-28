using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HillFacts.Client.Services;
using Propublica.CampaignFinance.Api.Contracts;

namespace HillFacts.Client.ViewModels
{
    public class CampFiSearchViewModel : BaseViewModel, ICampFiSearchViewModel
    {
        IEnumerable<CandidateSearchResult> searchResults;
        public IEnumerable<CandidateSearchResult> SearchResults
        {
            get { return searchResults; }
            set { SetValue<IEnumerable<CandidateSearchResult>>(ref searchResults, value); }
        }

        string query;
        public string Query
        {
            get { return query; }
            set { SetValue(ref query, value); }
        }

        string cycle;
        public string Cycle
        {
            get { return cycle; }
            set { SetValue(ref cycle, value); }
        }

        IAppCacheService cacheService;
        public CampFiSearchViewModel(IAppCacheService cacheService)
        {
            cycle = "2020";
            this.cacheService = cacheService;
        }
        public async Task GetSearchResults()
        {
            var response = await cacheService.CallCacheableServerMethod<CandidateSearchResponse>($"/api/PropublicaCampaignFinance/searchcandidate?cycle={Cycle}&query={Query}");
            SearchResults = response.Results;
        }

        protected override async void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            switch (propertyName)
            {
                case "Cycle":
                case "Query":
                    if (!string.IsNullOrEmpty(Query) || string.IsNullOrEmpty(Cycle))
                    {
                        await GetSearchResults();
                    }
                    break;
                default:
                    break;
            }
            base.OnPropertyChanged(propertyName);
        }
    }

}
