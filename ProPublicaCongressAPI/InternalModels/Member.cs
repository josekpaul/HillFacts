using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class Member
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("crp_id")]
        public string CrpId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("url")]
        public string HomeUrl { get; set; }

        [JsonProperty("times_topic_url")]
        public string TimesTopicsUrl { get; set; }

        [JsonProperty("times_tag")]
        public string TimesTag { get; set; }

        [JsonProperty("govtrack_id")]
        public int GovTrackId { get; set; }

        [JsonProperty("cspan_id")]
        public int? CspanId { get; set; }

        [JsonProperty("icpsr_id")]
        public int? IcpsrId { get; set; }

        [JsonProperty("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonProperty("facebook_account")]
        public string FacebookAccount { get; set; }

        [JsonProperty("youtube_account")]
        public string YoutubeAccount { get; set; }

        [JsonProperty("google_entity_id")]
        public string GoogleEntityId { get; set; }

        [JsonProperty("rss_url")]
        public string RssUrl { get; set; }

        [JsonProperty("domain")]
        public string HomeDomain { get; set; }

        [JsonProperty("current_party")]
        public string CurrentParty { get; set; }

        [JsonProperty("most_recent_vote")]
        public DateTime MostRecentVoteDate { get; set; }

        [JsonProperty("roles")]
        public IReadOnlyCollection<MemberRole> Roles { get; set; }

        [JsonProperty("votesmart_id")]
        public int? VotesmartId { get; set; }
    }
}