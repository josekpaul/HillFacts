using Newtonsoft.Json;
using ProPublicaCongressAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProPublicaCongressAPI
{
    public class ProPublicaCongressApiClient : IProPublicaCongressApiClient
    {
        private readonly string apiKey;

        private const string apiBaseUrl = "https://api.propublica.org/congress/";
        private const string membersUrl = "v1/{0}/{1}/members.json"; // 0 = congress, 1 = chamber
        private const string specificMemberUrl = "v1/members/{0}.json"; // 0 = member-id
        private const string newMembersUrl = "v1/members/new.json";
        private const string currentMembersUrl = "v1/members/{0}/{1}/current.json"; // 0 = chamber, 1 = state
        private const string currentHouseMembersUrl = "v1/members/{0}/{1}/{2}/current.json"; // 0 = chamber, 1 = state, 2 = district
        private const string memberVotesUrl = "v1/members/{0}/votes.json"; // 0 = member-id
        private const string compareMemberVotesUrl = "v1/members/{0}/votes/{1}/{2}/{3}.json"; // 0 = first-member-id, 1 = second-member-id, 2 = congress, 3 = chamber
        private const string compareMemberBillSponsorshipsUrl = "v1/members/{0}/bills/{1}/{2}/{3}.json"; // 0 = first-member-id, 1 = second-member-id, 2 = congress, 3 = chamber
        private const string memberCosponsoredBillsUrl = "v1/members/{0}/bills/{1}.json"; // 0 = member-id, 1 = type
        private const string voteRollCallUrl = "v1/{0}/{1}/sessions/{2}/votes/{3}.json"; // 0 = congress, 1 = chamber, 2 = session-number, 3 = roll-call-number
        private const string votesByTypeUrl = "v1/{0}/{1}/votes/{2}.json"; // 0 = congress, 1 = chamber, 2 = vote-type
        private const string votesByDateUrl = "v1/{0}/votes/{1}/{2}.json"; // 0 = chamber, 1 = year, 2 = month
        private const string senateNominationsUrl = "v1/{0}/nominations.json"; // 0 = congress
        private const string recentBillsUrl = "v1/{0}/{1}/bills/{2}.json"; // 0 = congress, 1 = chamber, 2 = bill-type
        private const string recentBillsByMemberUrl = "v1/members/{0}/bills/{1}.json"; // 0 = member-id, 1 = bill-type
        private const string specificBillUrl = "v1/{0}/bills/{1}.json"; // 0 = congress, 1 = bill-id
        private const string specificBillDetailsUrl = "v1/{0}/bills/{1}/{2}.json"; // 0 = congress, 1 = details-type, 2 = details-type
        private const string amendmentsUrl = "v1/{0}/bills/{1}/amendments.json"; // 0 = congress, 1 = details-type
        private const string billCosponsorsUrl = "v1/{0}/bills/{1}/cosponsors.json"; // 0 = congress, 1 = bill-id
        private const string recentNominationsByTypeUrl = "v1/{0}/nominees/{1}.json"; // 0 = congress, 1 = nomination-type
        private const string specificNominationUrl = "v1/{0}/nominees/{1}.json"; // 0 = congress, 1 = nominee-id
        private const string nomineesByStateUrl = "v1/{0}/nominees/state/{1}.json"; // 0 = congress, 1 = state
        private const string statePartyCountUrl = "v1/states/members/party.json";
        private const string committeesUrl = "v1/{0}/{1}/committees.json"; // 0 = congress, 1 = chamber
        private const string specificCommitteeUrl = "v1/{0}/{1}/committees/{2}.json"; // 0 = congress, 1 = chamber, 2 = committee-id
        private const string offsetParameter = "?offset={0}";

        public ProPublicaCongressApiClient(string apiKey)
        {
            this.apiKey = apiKey;
            AutoMapperConfiguration.Initialize();
        }

        public async Task<Contracts.SpecificCommittee> GetSpecificCommittee(int congress, Chamber chamber, string committeeId)
        {
            string url = apiBaseUrl + String.Format(specificCommitteeUrl, congress, chamber.ToString().ToLower(), committeeId);

            var internalModel = await GetMultipleResultDataAsync<InternalModels.SpecificCommittee>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.SpecificCommittee,
                Contracts.SpecificCommittee>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.CommitteesContainer> GetCommitttees(int congress, Chamber chamber)
        {
            string url = apiBaseUrl + String.Format(committeesUrl, congress, chamber.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.CommitteesContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.CommitteesContainer,
                Contracts.CommitteesContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<IReadOnlyCollection<Contracts.NomineeByState>> GetNomineesByState(int congress, string state)
        {
            string url = apiBaseUrl + String.Format(nomineesByStateUrl, congress, state);

            var internalModel = await GetMultipleResultDataAsync<InternalModels.NomineeByState>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                IReadOnlyCollection<InternalModels.NomineeByState>,
                IReadOnlyCollection<Contracts.NomineeByState>>(internalModel.Results);

            return contract;
        }

        public async Task<Contracts.SpecificNomination> GetSpecificNomination(int congress, string nominationId)
        {
            string url = apiBaseUrl + String.Format(specificNominationUrl, congress, nominationId);

            var internalModel = await GetMultipleResultDataAsync<InternalModels.SpecificNomination>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.SpecificNomination,
                Contracts.SpecificNomination>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<IReadOnlyCollection<Contracts.RecentNomination>> GetRecentNominations(int congress, RecentNominationType nominationType)
        {
            string url = apiBaseUrl + String.Format(recentNominationsByTypeUrl, congress, nominationType.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.RecentNomination>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                IReadOnlyCollection<InternalModels.RecentNomination>,
                IReadOnlyCollection< Contracts.RecentNomination>>(internalModel.Results);

            return contract;
        }

        public async Task<Contracts.BillCosponsorContainer> GetBillCosponsors(int congress, string billId)
        {
            string url = apiBaseUrl + String.Format(billCosponsorsUrl, congress, billId);

            var internalModel = await GetMultipleResultDataAsync<InternalModels.BillCosponsorContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.BillCosponsorContainer,
                Contracts.BillCosponsorContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.AmendmentsContainer> GetAmendments(int congress, string billId, int? offset)
        {
            string url = apiBaseUrl + String.Format(amendmentsUrl, congress, billId);

            // we can offset the results to page through them since this endpoint only returns 20 at a time
            if (offset.HasValue && offset.Value > 0)
            {
                url += String.Format(offsetParameter, offset.Value);
            }

            var internalModel = await GetMultipleResultDataAsync<InternalModels.AmendmentsContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.AmendmentsContainer,
                Contracts.AmendmentsContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.SpecificBillDetail> GetSpecificBillDetail(int congress, string billId, SpecificBillDetailType billDetailType)
        {
            string url = apiBaseUrl + String.Format(specificBillDetailsUrl, congress, billId, billDetailType.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.SpecificBillDetail>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.SpecificBillDetail,
                Contracts.SpecificBillDetail>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.SpecificBill> GetSpecificBill(int congress, string billId)
        {
            string url = apiBaseUrl + String.Format(specificBillUrl, congress, billId);
            
            var internalModel = await GetMultipleResultDataAsync<InternalModels.SpecificBill>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.SpecificBill,
                Contracts.SpecificBill>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.RecentBillsByMemberContainer> GetRecentBillsByMember(string memberId, RecentBillByMemberType billType, int? offset = null)
        {
            string url = apiBaseUrl + String.Format(recentBillsByMemberUrl, memberId, billType.ToString().ToLower());

            // we can offset the results to page through them since this endpoint only returns 20 at a time
            if (offset.HasValue && offset.Value > 0)
            {
                url += String.Format(offsetParameter, offset.Value);
            }

            var internalModel = await GetMultipleResultDataAsync<InternalModels.RecentBillsByMemberContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.RecentBillsByMemberContainer,
                Contracts.RecentBillsByMemberContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.RecentBillsContainer> GetRecentBills(int congress, Chamber chamber, RecentBillType billType, int? offset = null)
        {
            string url = apiBaseUrl + String.Format(recentBillsUrl, congress, chamber.ToString().ToLower(), billType.ToString().ToLower());

            // we can offset the results to page through them since this endpoint only returns 20 at a time
            if(offset.HasValue && offset.Value > 0)
            {
                url += String.Format(offsetParameter, offset.Value);
            }

            var internalModel = await GetMultipleResultDataAsync<InternalModels.RecentBillsContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.RecentBillsContainer,
                Contracts.RecentBillsContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.SenateNominationVoteContainer> GetSenateNominationVotes(int congress)
        {
            string url = apiBaseUrl + String.Format(senateNominationsUrl, congress);

            var internalModel = await GetMultipleResultDataAsync<InternalModels.SenateNominationVoteContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.SenateNominationVoteContainer,
                Contracts.SenateNominationVoteContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.VoteByDateContainer> GetVotesByDate(Chamber chamber, int year, int month)
        {
            string url = apiBaseUrl + String.Format(votesByDateUrl, chamber.ToString().ToLower(), year, month);

            var internalModel = await GetSingleResultDataAsync<InternalModels.VoteByDateContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.VoteByDateContainer,
                Contracts.VoteByDateContainer>(internalModel.Results);

            return contract;
        }

        public async Task<Contracts.VoteByTypeContainer> GetVotesByType(int congress, Chamber chamber, VoteAggregateCategory voteType)
        {
            string url = apiBaseUrl + String.Format(votesByTypeUrl, congress, chamber.ToString().ToLower(), voteType.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.VoteByTypeContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.VoteByTypeContainer,
                Contracts.VoteByTypeContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.RollCallVote> GetSpecificRollCallVote(int congress, Chamber chamber, Session session, int rollCallNumber)
        {
            string url = apiBaseUrl + String.Format(voteRollCallUrl, congress, chamber.ToString().ToLower(), (int)session, rollCallNumber);

            var internalModel = await GetSingleResultDataAsync<InternalModels.RollCallVotesContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.RollCallVotesContainer,
                Contracts.RollCallVotesContainer>(internalModel.Results);

            return contract.Votes.Vote;
        }

        public async Task<Contracts.MemberBillsCosponsoredContainer> GetBillsCosponsoredByMember(string memberId, CosponsorBillType type)
        {
            if (String.IsNullOrWhiteSpace(memberId))
            {
                throw new ArgumentNullException("memberId", "Member ID is required.");
            }

            string url = apiBaseUrl + String.Format(memberCosponsoredBillsUrl, memberId, type.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.MemberBillsCosponsoredContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.MemberBillsCosponsoredContainer,
                Contracts.MemberBillsCosponsoredContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<Contracts.MemberBillSponsorshipComparisonContainer> CompareMemberBillSponsorships(string firstMemberId, string secondMemberId, int congress, Chamber chamber)
        {
            if (String.IsNullOrWhiteSpace(firstMemberId))
            {
                throw new ArgumentNullException("firstMemberId", "First Member ID is required.");
            }

            if (String.IsNullOrWhiteSpace(secondMemberId))
            {
                throw new ArgumentNullException("secondMemberId", "Second Member ID is required.");
            }

            string url = apiBaseUrl + String.Format(compareMemberBillSponsorshipsUrl, firstMemberId, secondMemberId, congress, chamber.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.MemberBillSponsorshipComparisonContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<
                InternalModels.MemberBillSponsorshipComparisonContainer, 
                Contracts.MemberBillSponsorshipComparisonContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<IReadOnlyCollection<MemberVoteComparison>> CompareMemberVotes(string firstMemberId, string secondMemberId, int congress, Chamber chamber)
        {
            if (String.IsNullOrWhiteSpace(firstMemberId))
            {
                throw new ArgumentNullException("firstMemberId", "First Member ID is required.");
            }

            if (String.IsNullOrWhiteSpace(secondMemberId))
            {
                throw new ArgumentNullException("secondMemberId", "Second Member ID is required.");
            }

            string url = apiBaseUrl + String.Format(compareMemberVotesUrl, firstMemberId, secondMemberId, congress, chamber.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.MemberVoteComparison>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<IReadOnlyCollection<InternalModels.MemberVoteComparison>, IReadOnlyCollection<Contracts.MemberVoteComparison>> (internalModel.Results);

            return contract;
        }

        public async Task<Contracts.MemberVotesContainer> GetMemberVotesAsync(string memberId)
        {
            if (String.IsNullOrWhiteSpace(memberId))
            {
                throw new ArgumentNullException("memberId", "Member ID is required.");
            }

            string url = apiBaseUrl + String.Format(memberVotesUrl, memberId);

            var internalModel = await GetMultipleResultDataAsync<InternalModels.MemberVotesContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<InternalModels.MemberVotesContainer, Contracts.MemberVotesContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        public async Task<IReadOnlyCollection<Contracts.CurrentMember>> GetCurrentMembersAsync(Chamber chamber, string state, int? district = null)
        {
            if (chamber == Chamber.Unknown)
            {
                throw new ArgumentException("Chamber must be 'House' or 'Senate'.");
            }

            if (String.IsNullOrWhiteSpace(state))
            {
                throw new ArgumentNullException("state", "State is required.");
            }

            string url = apiBaseUrl;

            if (district.HasValue)
            {
                url += String.Format(currentHouseMembersUrl, chamber.ToString().ToLower(), state, district);
            }
            else
            {
                url += String.Format(currentMembersUrl, chamber.ToString().ToLower(), state);
            }

            var internalModel = await GetMultipleResultDataAsync<InternalModels.CurrentMember>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<IReadOnlyCollection<InternalModels.CurrentMember>, IReadOnlyCollection<Contracts.CurrentMember>>(internalModel.Results);

            return contract;
        }

        public async Task<Contracts.NewMembersContainer> GetNewMembersAsync()
        {
            string url = apiBaseUrl + newMembersUrl;
            
            var internalModel = await GetMultipleResultDataAsync<InternalModels.NewMembersContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<InternalModels.NewMembersContainer, Contracts.NewMembersContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        /// <summary>
        /// Returns a collection of members in whatever Congress and Chamber (House or Senate) is passed as parameters. Use the MemberUrl in the response to get more details about a specific member.
        /// </summary>
        /// <param name="congress">Number of Congress to query (ie. 2017 is the 115th Congress).</param>
        /// <param name="chamber">Chamber of Congress such as "house" or "senate".</param>
        /// <returns></returns>
        public async Task<Contracts.MembersContainer> GetMembersAsync(int congress, Chamber chamber)
        {
            if (chamber == Chamber.Unknown)
            {
                throw new ArgumentException("Chamber must be 'House' or 'Senate'.");
            }

            string url = apiBaseUrl + String.Format(membersUrl, congress, chamber.ToString().ToLower());

            var internalModel = await GetMultipleResultDataAsync<InternalModels.MembersContainer>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<InternalModels.MembersContainer, Contracts.MembersContainer>(internalModel.Results.ElementAt(0));

            return contract;
        }

        /// <summary>
        /// Returns details about a specific member of congress identified by the passed Member Id.
        /// </summary>
        /// <param name="memberId">Member Id retrieved from the list of Members.</param>
        /// <returns>A specific Member of Congress.</returns>
        public async Task<Contracts.Member> GetMemberAsync(string memberId)
        {
            if (String.IsNullOrWhiteSpace(memberId))
            {
                throw new ArgumentNullException("memberId", "Member ID is required.");
            }

            string url = apiBaseUrl + String.Format(specificMemberUrl, memberId);

            var internalModel = await GetMultipleResultDataAsync<InternalModels.Member>(url);
            var contract = AutoMapperConfiguration.Mapper.Map<InternalModels.Member, Contracts.Member>(internalModel.Results.ElementAt(0));

            return contract;
        }

        /// <summary>
        /// Returns some data from the ProPublica Congress API.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<ApiResponse<T>> GetSingleResultDataAsync<T>(string url)
        {
            Debug.Assert(!String.IsNullOrWhiteSpace(url));
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
            var membersJson = await httpClient.GetStringAsync(url);
            var resultInterface = JsonConvert.DeserializeObject<ApiResponse<T>>(membersJson);
            return resultInterface;
        }

        private async Task<ApiResponse<IReadOnlyCollection<T>>> GetMultipleResultDataAsync<T>(string url)
        {
            Debug.Assert(!String.IsNullOrWhiteSpace(url));
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
            var json = await httpClient.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<ApiResponse<IReadOnlyCollection<T>>>(json);
            return result;
        }
    }
}