using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberVote
    {
        public string MemberId { get; set; }

        public string Chamber { get; set; }

        public int Congress { get; set; }

        public int Session { get; set; }

        public int RollCall { get; set; }

        public MemberVoteBill Bill { get; set; }

        public string Description { get; set; }

        public string Question { get; set; }

        public DateTime DateTimeVoted { get; set; }

        public string Position { get; set; }
    }
}