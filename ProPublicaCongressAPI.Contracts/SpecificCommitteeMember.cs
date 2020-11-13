
using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificCommitteeMember
    {
        public string MemberId { get; set; }
        
        public string MemberName { get; set; }
        
        public string Party { get; set; }
        
        public string RankInParty { get; set; }
        
        public DateTime? DateStarted { get; set; }
        
        public DateTime? DateEnded { get; set; }
    }
}