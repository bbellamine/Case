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
    public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand, MemberCreatedResult>
    {
        private readonly IMembershipCommandRepository _membershipCommandRepository;

        public CreateMemberCommandHandler(IMembershipCommandRepository membershipCommandRepository)
        {
            _membershipCommandRepository = membershipCommandRepository;
        }
        public async Task<MemberCreatedResult> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            Membership member = await _membershipCommandRepository.GetByMailOrPhoneNumber(request.Mail, request.PhoneNumber);

            if (member != null)
            {
                throw new Exception("already exists");
            }
            ValidateMembershipEligibility(request);
            _membershipCommandRepository.AddMembership(request);
            Membership newMCreatedMember = await _membershipCommandRepository.GetByMailOrPhoneNumber(request.Mail, request.PhoneNumber);            
            return new MemberCreatedResult { 
            Id= newMCreatedMember.Id
            };
        }

        private void ValidateMembershipEligibility(CreateMemberCommand request)
        {
            throw new NotImplementedException();
        }
    }
}