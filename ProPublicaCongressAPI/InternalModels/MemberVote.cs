using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberVote
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("session")]
        public int Session { get; set; }

        [JsonProperty("roll_call")]
        public int RollCall { get; set; }

        [JsonProperty("bill")]
        public MemberVoteBill Bill { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("date")]
        public string DateVoted { get; set; }

        [JsonProperty("time")]
        public string TimeVoted { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }
}