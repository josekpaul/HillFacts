using HillFacts.Client.Services;
using ProPublicaCongressAPI.Contracts;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public class MemberDetailViewModel : BaseViewModel, IMemberDetailViewModel
    {
        string memberId;
        public string MemberId { get { return memberId; } set { SetValue<string>(ref memberId, value); } }
        Member member;
        public Member Member { get { return member; } set { SetValue<Member>(ref member, value); } }
        RecentBillsByMemberContainer recentSponsoredBills;
        public RecentBillsByMemberContainer RecentSponsoredBills
        { get { return recentSponsoredBills; } set { SetValue<RecentBillsByMemberContainer>(ref recentSponsoredBills, value); } }

        IAppCacheService cacheService;

        public MemberDetailViewModel(IAppCacheService cacheSvc)
        {
            cacheService = cacheSvc;
        }

        public async Task GetMemberDetail()
        {
            Member = await cacheService.CallCacheableServerMethod<Member>($"/api/Propublica/GetMemberDetail?id={MemberId}");
            RecentSponsoredBills = await cacheService.CallCacheableServerMethod<RecentBillsByMemberContainer>($"/api/Propublica/GetRecentBillsByMember?id={MemberId}"); ;
        }
    }
}
