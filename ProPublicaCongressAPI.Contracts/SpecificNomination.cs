using System;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificNomination
    {
        public int Congress { get; set; }
        public string NominationId { get; set; }
        public DateTime DateReceived { get; set; }
        public string Description { get; set; }
        public string NomineeState { get; set; }
        public string CommitteeDetailUrl { get; set; }
        public DateTime DateLatestAction { get; set; }
        public string Status { get; set; }
        public IReadOnlyCollection<SpecificNominationAction> Actions { get; set; }
        public IReadOnlyCollection<SpecificNominationVote> Votes { get; set; }
    }
}