using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class RollCallVotePosition
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("vote_position")]
        public string VotePosition { get; set; }

        [JsonProperty("dw_nominate")]
        public string DwNominate { get; set; }
    }
}