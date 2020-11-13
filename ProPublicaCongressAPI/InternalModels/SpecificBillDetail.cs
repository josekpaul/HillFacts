using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificBillDetail
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("bill")]
        public string BillNumber { get; set; }

        [JsonProperty("url_name")]
        public string BillUrlNumber { get; set; }

        [JsonProperty("title")]
        public string BillTitle { get; set; }

        [JsonProperty("sponsor")]
        public string SponsorMemberName { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorMemberId { get; set; }

        [JsonProperty("introduced_date")]
        public string DateIntroduced { get; set; }

        [JsonProperty("number_of_cosponsors")]
        public int CosponsorCount { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string DateLatestMajorAction { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("house_passage_vote")]
        public string DateHousePassageVote { get; set; }

        [JsonProperty("senate_passage_vote")]
        public string DateSenatePassageVote { get; set; }

        [JsonProperty("subjects")]
        public IReadOnlyCollection<SpecificBillDetailSubject> Subjects { get; set; }

        [JsonProperty("related_bills")]
        public IReadOnlyCollection<SpecificBillDetailRelated> RelatedBills { get; set; }
    }
}