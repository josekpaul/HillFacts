using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class CommitteesContainer
    {
        public int Congress { get; set; }
        public string Chamber { get; set; }
        public int NumberOfResults { get; set; }
        public int Offset { get; set; }
        public IReadOnlyCollection<Committee> Committees { get; set; }
    }
}