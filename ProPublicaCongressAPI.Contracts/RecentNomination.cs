using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class RecentNomination
    {
        public string NominationId { get; set; }
        public string NominationDetailUrl { get; set; }
        public DateTime DateReceived { get; set; }
        public string Description { get; set; }
        public string NomineeState { get; set; }
        public string CommitteeDetailUrl { get; set; }
        public DateTime DateLatestAction { get; set; }
        public string Status { get; set; }
    }
}