
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class AmendmentsContainer
    {
        public int Congress { get; set; }

        public string BillId { get; set; }

        public int NumberOfResults { get; set; }

        public int Offset { get; set; }

        public IReadOnlyCollection<Amendment> Amendments { get; set; }
    }
}