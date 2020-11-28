using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Propublica.CampaignFinance.Api.Contracts
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class IndependentExpenditureResult
    {
        [JsonPropertyName("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonPropertyName("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonPropertyName("fec_committee_name")]
        public string FecCommitteeName { get; set; }

        [JsonPropertyName("fec_candidate")]
        public string FecCandidate { get; set; }

        [JsonPropertyName("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonPropertyName("candidate_name")]
        public string CandidateName { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("office")]
        public string Office { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("district")]
        public object District { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        [JsonPropertyName("payee")]
        public string Payee { get; set; }

        [JsonPropertyName("date_received")]
        public string DateReceived { get; set; }

        [JsonPropertyName("support_or_oppose")]
        public string SupportOrOppose { get; set; }

        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        [JsonPropertyName("filing_id")]
        public int FilingId { get; set; }

        [JsonPropertyName("amended_from")]
        public int? AmendedFrom { get; set; }

        [JsonPropertyName("dissemination_date")]
        public string DisseminationDate { get; set; }

        [JsonPropertyName("form_type")]
        public object FormType { get; set; }

        [JsonPropertyName("miscellaneous_text")]
        public object MiscellaneousText { get; set; }
    }

    public class IndependentExpenditureResponse
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
        public List<IndependentExpenditureResult> Results { get; set; }
    }

}
