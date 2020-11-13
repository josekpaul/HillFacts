using Newtonsoft.Json;
using System;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class MemberSummary
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("api_uri")]
        public string MemberDetailUrl { get; set; }

        [JsonProperty("contact_form")]
        public string ContactForm { get; set; }

        [JsonProperty("crp_id")]
        public string CrpId { get; set; }

        [JsonProperty("cspan_id")]
        public int? CspanId { get; set; }

        [JsonProperty("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonProperty("facebook_account")]
        public string FacebookAccount { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("geoid")]
        public string GeoId { get; set; }

        [JsonProperty("google_entity_id")]
        public string GoogleEntityId { get; set; }

        [JsonProperty("govtrack_id")]
        public string GovTrackId { get; set; }

        [JsonProperty("icpsr_id")]
        public int? IcpsrId { get; set; }

        [JsonProperty("url")]
        public string HomeUrl { get; set; }

        [JsonProperty("rss_url")]
        public string RssUrl { get; set; }

        [JsonProperty("domain")]
        public string HomeDomain { get; set; }

        [JsonProperty("dw_nominate")]
        public string DwNominate { get; set; }

        [JsonProperty("ideal_point")]
        public string IdealPoint { get; set; }

        [JsonProperty("in_office")]
        public bool InOffice { get; set; }

        [JsonProperty("leadership_role")]
        public string LeadershipRole { get; set; }

        [JsonProperty("seniority")]
        public int Seniority { get; set; }

        [JsonProperty("next_election")]
        public int NextElection { get; set; }

        [JsonProperty("ocd_id")]
        public string OcdId { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("total_votes")]
        public int? TotalVotes { get; set; }

        [JsonProperty("missed_votes")]
        public int? MissedVotes { get; set; }

        [JsonProperty("total_present")]
        public int? TotalPresent { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("votesmart_id")]
        public int? VotesmartId { get; set; }

        [JsonProperty("missed_votes_pct")]
        public double PercentageOfVotesMissed { get; set; }

        [JsonProperty("votes_with_party_pct")]
        public double PercentageOVotesWithParty { get; set; }

        [JsonProperty("youtube_account")]
        public string YoutubeAccount { get; set; }
    }
}