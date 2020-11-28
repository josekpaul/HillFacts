using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ProPublicaCongressAPI;
using ProPublicaCongressAPI.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HillFacts.Server.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class PropublicaCongressController : ControllerBase
    {
        ProPublicaCongressApiClient _propublica;

        public PropublicaCongressController(IOptions<HillFactsConfig> config, IMapper mapper)
        {
            _propublica = new ProPublicaCongressApiClient (config.Value.PropublicaApiKey);
        }

        public async Task<IEnumerable<MemberSummary>> GetMembers(Chamber chamber)
        {
            var membercollection = await _propublica.GetMembersAsync(116, chamber);
            return membercollection.Members;
        }

        public async Task<Member> GetMemberDetail(string id)
        {
            var member = await _propublica.GetMemberAsync(id);
            return member;
        }

        public async Task<RecentBillsByMemberContainer> GetRecentBillsByMember(string id)
        {
            var bills = await _propublica.GetRecentBillsByMember(id, RecentBillByMemberType.Introduced);
            return bills;
        }

        public async Task<RecentBillsContainer> GetBills(Chamber chamber, RecentBillType billtype)
        {
            var bills = await _propublica.GetRecentBills(116, chamber, billtype);
            return bills;
        }
    }
}
