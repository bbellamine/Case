using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MembershipDisco.Business.Member.Commands
{
    public class BlackListMemberCommand : IRequest<bool>
    {
        public long Id { get; set; }
        public DateTime UnblacklistDate { get; set; }
    }
}