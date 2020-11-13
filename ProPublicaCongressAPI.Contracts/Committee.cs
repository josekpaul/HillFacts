namespace ProPublicaCongressAPI.Contracts
{
    public class Committee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string HomeUrl { get; set; }
        public string DemocratRssFeedUrl { get; set; }
        public string RepublicanRssFeedUrl { get; set; }
        public string CommitteeDetailUrl { get; set; }
        public string ChairMemberName { get; set; }
        public string ChairMemberId { get; set; }
        public string ChairParty { get; set; }
        public string ChairState { get; set; }
        public string ChairMemberDetailUrl { get; set; }
        public string RankingMemberId { get; set; }
    }
}