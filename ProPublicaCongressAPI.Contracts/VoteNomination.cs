using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.Contracts
{
    public class VoteNomination
    {
        public string Id { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public string Agency { get; set; }
    }
}
