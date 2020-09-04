using MediatR;
using MembershipDisco.Business.Member.Queries.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MembershipDisco.Business.Member.Queries.Handlers
{
    public class GetIfMemberBlacklistedQueryHandler : IRequestHandler<GetIfMemberBlacklistedQuery, GetIfMemberBlacklistedResult>
    {
        public Task<GetIfMemberBlacklistedResult> Handle(GetIfMemberBlacklistedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}