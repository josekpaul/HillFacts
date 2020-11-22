using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Propublica.CampaignFinance.Api.Contracts
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class IndependentExpenditurePerCandidateResult
    {
        [JsonPropertyName("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonPropertyName("fec_committee_name")]
        public string FecCommitteeName { get; set; }

        [JsonPropertyName("candidate_name")]
        public string CandidateName { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("office")]
        public string Office { get; set; }

        [JsonPropertyName("state")]
        public object State { get; set; }

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

        [JsonPropertyName("fec_uri")]
        public object FecUri { get; set; }

        [JsonPropertyName("amendment")]
        public object Amendment { get; set; }

        [JsonPropertyName("support_or_oppose")]
        public string SupportOrOppose { get; set; }

        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        [JsonPropertyName("filing_id")]
        public int FilingId { get; set; }

        [JsonPropertyName("amended_from")]
        public object AmendedFrom { get; set; }

        [JsonPropertyName("dissemination_date")]
        public string DisseminationDate { get; set; }

        [JsonPropertyName("form_type")]
        public string FormType { get; set; }
    }

    public class IndependentExpenditurePerCandidateResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("base_uri")]
        public string BaseUri { get; set; }

        [JsonPropertyName("cycle")]
        public int Cycle { get; set; }

        [JsonPropertyName("fec_candidate")]
        public string FecCandidate { get; set; }

        [JsonPropertyName("support_total")]
        public double SupportTotal { get; set; }

        [JsonPropertyName("oppose_total")]
        public double OpposeTotal { get; set; }

        [JsonPropertyName("offset")]
        public object Offset { get; set; }

        [JsonPropertyName("results")]
        public List<IndependentExpenditurePerCandidateResult> Results { get; set; }
    }


}
