using HillFacts.Client.Services;
using ProPublicaCongressAPI.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public enum PageSearchState
    {
        Initializing, Searching, HasResults, NoResults
    }


    public class LobbyingViewModel:BaseViewModel,ILobbyingViewModel
    {
        public PageSearchState PageSearchState { get; set; }
        IAppCacheService cacheService;
        string query;
        public List<LobbyingRepresentation> representations { get; set; }

        public LobbyingViewModel(IAppCacheService cacheSvc)
        {
            cacheService = cacheSvc;
        }

        public string Query
        {
            get { return query; }
            set { SetValue(ref query, value); }
        }

        public async Task<List<LobbyingRepresentation>> LobbyingSearch(string query)
        {
            var searchResults = await cacheService.CallCacheableServerMethod<List<LobbyingRepresentation>>($"/api/PropublicaCongress/LobbyingSearch?term={query}");
            return searchResults;
        }

        protected override async void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (propertyName == "Query")
            {
                if (!string.IsNullOrEmpty(Query))
                {
                    PageSearchState = PageSearchState.Searching;
                    var results =await LobbyingSearch(Query);
                    representations = results;
                    
                    if (results != null && results.Count > 0)
                    {
                        PageSearchState = PageSearchState.HasResults;
                    }

                    else
                    {
                        PageSearchState = PageSearchState.NoResults;
                    }
                }
            }
            base.OnPropertyChanged(propertyName);
        }

        public async Task<List<LobbyingRepresentation>> RecentLobbying()
        {
            PageSearchState = PageSearchState.Initializing;
            var recentLobbyingActivity = await cacheService.CallCacheableServerMethod<List<LobbyingRepresentation>>($"/api/PropublicaCongress/GetLobbyingActivity");
            PageSearchState = PageSearchState.HasResults;
            return recentLobbyingActivity;
        }
    }
}
