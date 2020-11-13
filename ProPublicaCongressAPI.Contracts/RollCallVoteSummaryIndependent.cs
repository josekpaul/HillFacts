namespace ProPublicaCongressAPI.Contracts
{
    public class RollCallVoteSummaryIndependent
    {
        public int YesCount { get; set; }

        public int NoCount { get; set; }

        public int PresentVoterCount { get; set; }

        public int NotVotingCount { get; set; }
    }
}