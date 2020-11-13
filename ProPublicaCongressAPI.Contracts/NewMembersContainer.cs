using System.Collections.Generic;

namespace ProPublicaCongressAPI.Contracts
{
    public class NewMembersContainer
    {
        public int NumberOfResults { get; set; }

        public int Offset { get; set; }

        public IReadOnlyCollection<NewMember> Members { get; set; }
    }
}