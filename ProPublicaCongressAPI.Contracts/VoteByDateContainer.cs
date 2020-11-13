using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class VoteByDateContainer
    {
        public Chamber Chamber { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        public int NumberOfResults { get; set; }
        public IReadOnlyCollection<VoteByDate> Votes { get; set; }
    }
}