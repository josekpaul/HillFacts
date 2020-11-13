using Newtonsoft.Json;
using System;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberBillCosponsored
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillDetailUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cosponsored_date")]
        public DateTime DateCosponsored { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorMemberId { get; set; }

        [JsonProperty("introduced_date")]
        public DateTime DateIntroduced { get; set; }

        [JsonProperty("cosponsors")]
        public int CosponsorCount { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("latest_major_action_date")]
        public DateTime DateLastMajorAction { get; set; }

        [JsonProperty("latest_major_action")]
        public string LastMajorAction { get; set; }
    }
}