namespace ProPublicaCongressAPI.Contracts
{
    public class MemberVoteBill
    {
        public string Number { get; set; }

        public string BillUrl { get; set; }

        public string Title { get; set; }

        public string LatestAction { get; set; }
    }
}