

namespace ProPublicaCongressAPI.Contracts
{
    public class VoteBill
    {
        public string BillId { get; set; }

        public string BillNumber { get; set; }

        public string BillTitle { get; set; }

        public string ApiUrl { get; set; }        

        public string LatestAction { get; set; }
    }
}