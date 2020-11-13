
using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class MemberSummary
    {
        public string Id { get; set; }
        public string MemberDetailUrl { get; set; }
        public string ContactForm { get; set; }
        public string CrpId { get; set; }
        public int? CspanId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Party { get; set; }
        public string TwitterAccount { get; set; }
        public string FacebookAccount { get; set; }
        [Obsolete("This property is no longer returned by the API and should not be used")]
        public long? FacebookId { get; set; }
        public string Fax { get; set; }
        public string GeoId { get; set; }
        public string GoogleEntityId { get; set; }
        public string GovTrackId { get; set; }
        public int IcpsrId { get; set; }
        public string HomeUrl { get; set; }
        public string RssUrl { get; set; }
        public string HomeDomain { get; set; }
        public string DwNominate { get; set; }
        public string IdealPoint { get; set; }
        public bool InOffice { get; set; }
        public string LeadershipRole { get; set; }
        public int Seniority { get; set; }
        public int NextElection { get; set; }
        public string OcdId { get; set; }
        public string Office { get; set; }
        public string Phone { get; set; }
        public int? TotalVotes { get; set; }
        public int? MissedVotes { get; set; }
        public int? TotalPresent { get; set; }
        public string State { get; set; }
        public int District { get; set; }
        public int? VotesmartId { get; set; }
        public double PercentageOfVotesMissed { get; set; }
        public double PercentageOVotesWithParty { get; set; }
        public string YoutubeAccount { get; set; }
    }
}