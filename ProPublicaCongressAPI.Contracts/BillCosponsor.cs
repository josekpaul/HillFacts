using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class BillCosponsor
    {
        public string CosponsorMemberId { get; set; }
        public string CosponsorMemberName { get; set; }
        public DateTime DateCosponsored { get; set; }
    }
}