namespace ProPublicaCongressAPI.Contracts
{
    public class RollCallVoteSummaryDemocratic
    {
        public int YesCount { get; set; }

        public int NoCount { get; set; }

        public int PresentVoterCount { get; set; }

        public int NotVotingCount { get; set; }

        public string MajorityPosition { get; set; }
    }
}