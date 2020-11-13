
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificCommittee
    {
        public int Congress { get; set; }
        
        public string Chamber { get; set; }
        
        public string CommitteeName { get; set; }
        
        public int NumberOfResults { get; set; }
        
        public int Offset { get; set; }
        
        public string ChairmanMemberId { get; set; }
        
        public string RankingMemberId { get; set; }
        
        public string DemocratRssFeedUrl { get; set; }
        
        public string RepublicaRssFeedUrl { get; set; }
        
        public IReadOnlyCollection<SpecificCommitteeMember> CurrentMembers { get; set; }
        
        public IReadOnlyCollection<SpecificCommitteeMember> FormerMembers { get; set; }
    }
}