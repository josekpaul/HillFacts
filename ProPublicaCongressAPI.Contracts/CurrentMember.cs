namespace ProPublicaCongressAPI.Contracts
{
    public class CurrentMember
    {
        public string MemberId { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public string Gender { get; set; }

        public string Party { get; set; }

        public string TimesTopicsUrl { get; set; }

        public string TwitterAccount { get; set; }

        public string YouTubeAccount { get; set; }

        public int Seniority { get; set; }

        public int NextElectionYear { get; set; }

        public string MemberDetailUrl { get; set; }

        public int? District { get; set; }
    }
}