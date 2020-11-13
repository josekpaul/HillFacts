using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class NomineeByState
    {
        public string NomineeId { get; set; }
        public string NomineeDetailUrl { get; set; }
        public DateTime DateReceived { get; set; }
        public string Description { get; set; }
        public string NomineeState { get; set; }
        public DateTime DateLatestAction { get; set; }
        public string Status { get; set; }
    }
}