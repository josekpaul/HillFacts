﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Options;
using AutoMapper;
using ProPublicaCongressAPI;
using ProPublicaCongressAPI.Contracts;

namespace HillFacts.Server.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class PropublicaController : ControllerBase
    {
        ProPublicaCongressApiClient _propublica;

        public PropublicaController(IOptions<HillFactsConfig> config, IMapper mapper)
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
