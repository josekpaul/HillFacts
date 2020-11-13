
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberBillsCosponsoredContainer
    {
        public string MemberId { get; set; }
        
        public string MemberDetailUrl { get; set; }
        
        public string MemberName { get; set; }
        
        public int NumberOfResults { get; set; }
        
        public int Offset { get; set; }
        
        public IReadOnlyCollection<MemberBillCosponsored> Bills { get; set; }
    }
}