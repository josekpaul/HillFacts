using Newtonsoft.Json;
using System;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberBillSponsorshipComparison
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("api_uri")]
        public string BillDetailUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorMemberDetailUrl { get; set; }

        [JsonProperty("introduced_date")]
        public DateTime DateIntroduced { get; set; }

        [JsonProperty("cosponsors")]
        public int CosponsorCount { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("latest_major_action_date")]
        public DateTime DateLatestMajorAction { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("first_member_date")]
        public DateTime DateFirstMember { get; set; }

        [JsonProperty("second_member_date")]
        public DateTime DateSecondMember { get; set; }
    }
}