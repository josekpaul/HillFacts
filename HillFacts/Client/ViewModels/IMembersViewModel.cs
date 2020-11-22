using ProPublicaCongressAPI.Contracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public interface IMembersViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;

        Chamber CurrentChamber { get; set; }
        string Filter { get; set; }
        IEnumerable<MemberSummary> FilteredMembers { get; set; }
        MembersSortCriteria Sort { get; set; }
        Task GetMembers();
    }
}