using ProPublicaCongressAPI.Contracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public interface ILobbyingViewModel
    {
        PageSearchState PageSearchState { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
        List<LobbyingRepresentation> representations { get; set; }
        string Query { get; set; }
        Task<List<LobbyingRepresentation>> LobbyingSearch(string query);
        Task<List<LobbyingRepresentation>> RecentLobbying();
    }
}
