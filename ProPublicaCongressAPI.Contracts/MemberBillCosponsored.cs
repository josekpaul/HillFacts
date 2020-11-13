
using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberBillCosponsored
    {
        public int Congress { get; set; }
        
        public string Number { get; set; }
        
        public string BillDetailUrl { get; set; }
        
        public string Title { get; set; }
        
        public DateTime DateCosponsored { get; set; }
        
        public string SponsorMemberId { get; set; }
        
        public DateTime DateIntroduced { get; set; }
        
        public int CosponsorCount { get; set; }
        
        public string PrimarySubject { get; set; }
        
        public DateTime DateLastMajorAction { get; set; }
        
        public string LastMajorAction { get; set; }
    }
}