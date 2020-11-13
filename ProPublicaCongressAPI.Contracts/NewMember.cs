using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class NewMember
    {
        public string MemberId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Party { get; set; }

        public string Chamber { get; set; }

        public string State { get; set; }

        public DateTime StartDate { get; set; }
    }
}