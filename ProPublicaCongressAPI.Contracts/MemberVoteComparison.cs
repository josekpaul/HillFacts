namespace ProPublicaCongressAPI.Contracts
{
    public class MemberVoteComparison
    {
        public string FirstMemberId { get; set; }

        public string FirstMemberDetailUrl { get; set; }

        public string SecondMemberId { get; set; }

        public string SecondMemberDetailUrl { get; set; }

        public int Congress { get; set; }

        public string Chamber { get; set; }

        public int AgreeVoteCount { get; set; }

        public int DisagreeVoteCount { get; set; }

        public double AgreeVotePercent { get; set; }

        public double DisagreeVotePercent { get; set; }
    }
}