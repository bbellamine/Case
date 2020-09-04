using MediatR;
using MembershipDisco.Business.Member.Commands;
using MembershipDisco.Business.Member.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MembershipDisco.Controllers
{
    public class MemberController : ApiController
    {
        private readonly IMediator _mediator;

        [HttpPost]
        [Route]
        public async Task<IHttpActionResult> Create([FromBody] CreateMemberCommand command)
        {
            var result = await _mediator.Send(command);
            return Created(Request.RequestUri, result);
        }

        [HttpPut]
        [Route("{memberId}")]
        public async Task<IHttpActionResult> Update(long memberId, [FromBody] UpdateMemberCommand updateCommand)
        {
            updateCommand.Id = memberId;
            await _mediator.Send(updateCommand);
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        [HttpPost]
        [Route("BlacklistMember/{memberId}")]
        public async Task<IHttpActionResult> BlackListMember(long memberId, [FromBody] BlackListMemberCommand blacklistCommand)
        {
            var result = await _mediator.Send(new BlackListMemberCommand
            {
                Id = memberId
            });
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        [HttpGet]
        [Route("IsMemberBlacklisted/{memberId}")]
        public async Task<IHttpActionResult> IsMemberBlacklisted(int memberId)
        {
            var result = await _mediator.Send(new GetIfMemberBlacklistedQuery
            {
                Id = memberId
            });
            return Ok(result);
        }       
    }
}
