using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Propublica.CampaignFinance.Api.Contracts
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class CandidateResult
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("party")]
        public string Party { get; set; }

        [JsonPropertyName("district")]
        public object District { get; set; }

        [JsonPropertyName("fec_uri")]
        public string FecUri { get; set; }

        [JsonPropertyName("committee")]
        public string Committee { get; set; }

        [JsonPropertyName("state")]
        public object State { get; set; }

        [JsonPropertyName("mailing_address")]
        public string MailingAddress { get; set; }

        [JsonPropertyName("mailing_city")]
        public string MailingCity { get; set; }

        [JsonPropertyName("mailing_state")]
        public string MailingState { get; set; }

        [JsonPropertyName("mailing_zip")]
        public string MailingZip { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("total_receipts")]
        public double TotalReceipts { get; set; }

        [JsonPropertyName("total_from_individuals")]
        public double TotalFromIndividuals { get; set; }

        [JsonPropertyName("total_from_individuals_itemized")]
        public double TotalFromIndividualsItemized { get; set; }

        [JsonPropertyName("total_from_individuals_unitemized")]
        public double TotalFromIndividualsUnitemized { get; set; }

        [JsonPropertyName("percent_unitemized")]
        public double PercentUnitemized { get; set; }

        [JsonPropertyName("total_from_pacs")]
        public double TotalFromPacs { get; set; }

        [JsonPropertyName("total_contributions")]
        public double TotalContributions { get; set; }

        [JsonPropertyName("candidate_loans")]
        public double CandidateLoans { get; set; }

        [JsonPropertyName("transfers_in")]
        public double TransfersIn { get; set; }

        [JsonPropertyName("total_disbursements")]
        public double TotalDisbursements { get; set; }

        [JsonPropertyName("begin_cash")]
        public double BeginCash { get; set; }

        [JsonPropertyName("end_cash")]
        public double EndCash { get; set; }

        [JsonPropertyName("total_refunds")]
        public double TotalRefunds { get; set; }

        [JsonPropertyName("individual_refunds")]
        public double IndividualRefunds { get; set; }

        [JsonPropertyName("pac_refunds")]
        public double PacRefunds { get; set; }

        [JsonPropertyName("debts_owed")]
        public double DebtsOwed { get; set; }

        [JsonPropertyName("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonPropertyName("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonPropertyName("independent_expenditures")]
        public double IndependentExpenditures { get; set; }

        [JsonPropertyName("coordinated_expenditures")]
        public double CoordinatedExpenditures { get; set; }

        [JsonPropertyName("other_cycles")]
        public List<int> OtherCycles { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("google_id")]
        public string GoogleId { get; set; }

        [JsonPropertyName("twitter_user")]
        public string TwitterUser { get; set; }
    }

    public class CandidateResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("base_uri")]
        public string BaseUri { get; set; }

        [JsonPropertyName("cycle")]
        public int Cycle { get; set; }

        [JsonPropertyName("results")]
        public List<CandidateResult> Results { get; set; }
    }


}
