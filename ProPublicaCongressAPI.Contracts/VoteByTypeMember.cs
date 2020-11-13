

namespace ProPublicaCongressAPI.Contracts
{
    public class VoteByTypeMember
    {
        public string MemberId { get; set; }
        
        public string MemberName { get; set; }
        
        public string Party { get; set; }
        
        public string State { get; set; }
        
        public string District { get; set; }
        
        public int? TotalVoteCount { get; set; }
        
        public int? VotesWithPartyCount { get; set; }
        
        public double? VotesWithPartyPercent { get; set; }
        
        public int? VotesMissedCount { get; set; }
        
        public double? VotesMissedPercent { get; set; }
        
        public int? VotesLoneNoCount { get; set; }
        
        public int Rank { get; set; }
        
        public string Notes { get; set; }
    }
}