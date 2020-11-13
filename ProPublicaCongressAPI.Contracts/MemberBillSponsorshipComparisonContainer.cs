using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberBillSponsorshipComparisonContainer
    {
        public string FirstMemberDetailUrl { get; set; }

        public string SecondMemberDetailUrl { get; set; }

        public string Chamber { get; set; }

        public int Congress { get; set; }

        public int CommonBillCount { get; set; }

        public IReadOnlyCollection<MemberBillSponsorshipComparison> Bills { get; set; }
    }
}