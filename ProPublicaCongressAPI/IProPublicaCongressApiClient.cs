using System.Collections.Generic;
using System.Threading.Tasks;
using ProPublicaCongressAPI.Contracts;

namespace ProPublicaCongressAPI
{
    public interface IProPublicaCongressApiClient
    {
        Task<List<LobbyingRepresentation>> LobbyingSearch(string query);
        Task<List<LobbyingRepresentation>> GetRecentLobbyingActivity();
        Task<MemberBillSponsorshipComparisonContainer> CompareMemberBillSponsorships(string firstMemberId, string secondMemberId, int congress, Chamber chamber);
        Task<IReadOnlyCollection<MemberVoteComparison>> CompareMemberVotes(string firstMemberId, string secondMemberId, int congress, Chamber chamber);
        Task<Contracts.AmendmentsContainer> GetAmendments(int congress, string billId, int? offset);
        Task<BillCosponsorContainer> GetBillCosponsors(int congress, string billId);
        Task<MemberBillsCosponsoredContainer> GetBillsCosponsoredByMember(string memberId, CosponsorBillType type);
        Task<CommitteesContainer> GetCommitttees(int congress, Chamber chamber);
        Task<IReadOnlyCollection<CurrentMember>> GetCurrentMembersAsync(Chamber chamber, string state, int? district = null);
        Task<Member> GetMemberAsync(string memberId);
        Task<MembersContainer> GetMembersAsync(int congress, Chamber chamber);
        Task<MemberVotesContainer> GetMemberVotesAsync(string memberId);
        Task<NewMembersContainer> GetNewMembersAsync();
        Task<IReadOnlyCollection<NomineeByState>> GetNomineesByState(int congress, string state);
        Task<RecentBillsContainer> GetRecentBills(int congress, Chamber chamber, RecentBillType billType, int? offset = null);
        Task<RecentBillsByMemberContainer> GetRecentBillsByMember(string memberId, RecentBillByMemberType billType, int? offset = null);
        Task<IReadOnlyCollection<RecentNomination>> GetRecentNominations(int congress, RecentNominationType nominationType);
        Task<SenateNominationVoteContainer> GetSenateNominationVotes(int congress);
        Task<SpecificBill> GetSpecificBill(int congress, string billId);
        Task<SpecificBillDetail> GetSpecificBillDetail(int congress, string billId, SpecificBillDetailType billDetailType);
        Task<SpecificCommittee> GetSpecificCommittee(int congress, Chamber chamber, string committeeId);
        Task<SpecificNomination> GetSpecificNomination(int congress, string nominationId);
        Task<RollCallVote> GetSpecificRollCallVote(int congress, Chamber chamber, Session session, int rollCallNumber);
        Task<VoteByDateContainer> GetVotesByDate(Chamber chamber, int year, int month);
        Task<VoteByTypeContainer> GetVotesByType(int congress, Chamber chamber, VoteAggregateCategory voteType);
    }
}