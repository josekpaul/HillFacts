using Microsoft.VisualStudio.TestTools.UnitTesting;
using Propublica.CampaignFinance.Api;

namespace Propublica.CampaignFinance.Api.Tests
{
    [TestClass]
    public class CandidateTests
    {
        [TestMethod]
        public void SearchCandidates()
        {
            var client = new ApiClient("apikey");
            var candidates = client.SearchCandidates("2020", "Wilson").GetAwaiter().GetResult();
            Assert.IsNotNull(candidates);
        }
    }
}
