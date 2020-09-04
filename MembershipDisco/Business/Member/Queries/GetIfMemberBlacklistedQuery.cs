using MediatR;
using MembershipDisco.Business.Member.Queries.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MembershipDisco.Business.Member.Queries
{
    public class GetIfMemberBlacklistedQuery : IRequest<GetIfMemberBlacklistedResult>
    {
        public long Id { get; set; }
    }
}