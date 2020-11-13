namespace ProPublicaCongressAPI.Contracts
{
    public class RollCallVoteSummaryTotal
    {
        public int YesCount { get; set; }
        public int NoCount { get; set; }
        public int PresentVoterCount { get; set; }
        public int NotVotingCount { get; set; }
    }
}