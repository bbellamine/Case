using MediatR;
using MembershipDisco.Business.Interfaces;
using MembershipDisco.Business.Member.Commands.Result;
using MembershipDisco.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MembershipDisco.Business.Member.Commands.Handlers
{
    public class UpdateMemberCommandHandler : IRequestHandler<UpdateMemberCommand, bool>
    {
        private readonly IMembershipCommandRepository _membershipCommandRepository;

        public UpdateMemberCommandHandler(IMembershipCommandRepository membershipCommandRepository)
        {
            _membershipCommandRepository = membershipCommandRepository;
        }
        public async Task<bool> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
        {
            Membership member = await _membershipCommandRepository.GetById(request.Id);

            if (member == null)
            {
                throw new Exception("member does not exists");
            }
            ValidateMembershipEligibility(request);
            _membershipCommandRepository.UpdateMembership(request);
            return true;
        }

        private void ValidateMembershipEligibility(UpdateMemberCommand request)
        {
            throw new NotImplementedException();
        }
    }
}