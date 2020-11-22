using ProPublicaCongressAPI.Contracts;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public interface IMemberDetailViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;

        string MemberId { get; set; }
        Member Member { get; set; }
        RecentBillsByMemberContainer RecentSponsoredBills { get; set; }

        Task GetMemberDetail();

    }
}