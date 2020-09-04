using MediatR;
using MembershipDisco.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MembershipDisco.Business.Member.Commands.Handlers
{
    public class BlackListMemberCommandHandler : IRequestHandler<BlackListMemberCommand, bool>
    {
        private readonly IMembershipCommandRepository _membershipCommandRepository;

        public BlackListMemberCommandHandler(IMembershipCommandRepository membershipCommandRepository)
        {
            _membershipCommandRepository = membershipCommandRepository;
        }
        public Task<bool> Handle(BlackListMemberCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}