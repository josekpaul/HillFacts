using HillFacts.Client.Services;
using ProPublicaCongressAPI.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HillFacts.Client.ViewModels
{
    public enum MembersSortCriteria
    {
        None, StateAsc, StateDesc, AgeAsc, AgeDesc, ElectionYearAsc, ElectionYearDesc, PercentPartyVoteAsc, PercentPartyVoteDesc, PercentVoteMissAsc,
        PercentVoteMissDesc, TotalVoteAsc, TotalVoteDesc, SeniorityAsc, SeniorityDesc, MissedVotesAsc, MissedVotesDesc
    }

    public class MembersViewModel : BaseViewModel, IMembersViewModel
    {

        Chamber currentChamber;
        public Chamber CurrentChamber
        {
            get { return currentChamber; }
            set { SetValue<Chamber>(ref currentChamber, value); }
        }

        IEnumerable<MemberSummary> chamberMembers;
        IEnumerable<MemberSummary> filteredMembers;
        public IEnumerable<MemberSummary> FilteredMembers
        {
            get { return filteredMembers; }
            set { SetValue<IEnumerable<MemberSummary>>(ref filteredMembers, value); }
        }

        string filter = string.Empty;
        public string Filter
        {
            get { return filter; }
            set
            {
                SetValue<string>(ref filter, value);
                if (filter.Length == 2)
                {
                    FilteredMembers = chamberMembers.Where(s => s.State.Equals(filter, StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    FilteredMembers = chamberMembers.Where(s => (s.State + " " + s.FirstName + " " + s.LastName).Contains(filter, StringComparison.OrdinalIgnoreCase));
                }
            }
        }

        MembersSortCriteria sort = MembersSortCriteria.None;
        public MembersSortCriteria Sort
        {
            get { return sort; }
            set
            {
                SetValue<MembersSortCriteria>(ref sort, value);
                if (sort != MembersSortCriteria.None)
                {
                    switch (sort)
                    {
                        case MembersSortCriteria.AgeAsc:
                            FilteredMembers = FilteredMembers.OrderByDescending(m => m.DateOfBirth);
                            break;
                        case MembersSortCriteria.AgeDesc:
                            FilteredMembers = FilteredMembers.OrderBy(m => m.DateOfBirth);
                            break;
                        case MembersSortCriteria.ElectionYearAsc:
                            FilteredMembers = FilteredMembers.OrderBy(m => m.NextElection);
                            break;
                        case MembersSortCriteria.MissedVotesAsc:
                            FilteredMembers = FilteredMembers.OrderBy(m => m.MissedVotes);
                            break;
                        case MembersSortCriteria.PercentPartyVoteAsc:
                            FilteredMembers = FilteredMembers.OrderBy(m => m.PercentageOVotesWithParty);
                            break;
                        case MembersSortCriteria.SeniorityAsc:
                            FilteredMembers = FilteredMembers.OrderBy(m => m.Seniority);
                            break;
                        case MembersSortCriteria.PercentVoteMissAsc:
                            FilteredMembers = FilteredMembers.OrderBy(m => m.PercentageOfVotesMissed);
                            break;
                        case MembersSortCriteria.StateAsc:
                            FilteredMembers = FilteredMembers.OrderBy(m => m.State).ThenBy(m => m.District);
                            break;
                        case MembersSortCriteria.StateDesc:
                            FilteredMembers = FilteredMembers.OrderByDescending(m => m.State).ThenByDescending(m => m.District);
                            break;
                        case MembersSortCriteria.ElectionYearDesc:
                            FilteredMembers = FilteredMembers.OrderByDescending(m => m.NextElection);
                            break;
                        case MembersSortCriteria.MissedVotesDesc:
                            FilteredMembers = FilteredMembers.OrderByDescending(m => m.MissedVotes);
                            break;
                        case MembersSortCriteria.PercentPartyVoteDesc:
                            FilteredMembers = FilteredMembers.OrderByDescending(m => m.PercentageOVotesWithParty);
                            break;
                        case MembersSortCriteria.SeniorityDesc:
                            FilteredMembers = FilteredMembers.OrderByDescending(m => m.Seniority);
                            break;
                        case MembersSortCriteria.PercentVoteMissDesc:
                            FilteredMembers = FilteredMembers.OrderByDescending(m => m.PercentageOfVotesMissed);
                            break;
                        default: return;
                    }
                }
            }
        }

        IAppCacheService cacheService;

        public MembersViewModel(IAppCacheService cacheSvc)
        {
            cacheService = cacheSvc;
        }

        public async Task GetMembers()
        {
            chamberMembers = await cacheService.CallCacheableServerMethod<List<MemberSummary>>($"/api/PropublicaCongress/GetMembers?chamber={CurrentChamber.ToString()}");
            FilteredMembers = chamberMembers;
        }
    }
}
