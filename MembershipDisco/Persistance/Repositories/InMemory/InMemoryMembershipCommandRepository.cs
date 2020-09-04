using MembershipDisco.Business.Interfaces;
using MembershipDisco.Business.Member.Commands;
using MembershipDisco.Persistance.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MembershipDisco.Persistance.Repositories.InMemory
{
    public class InMemoryMembershipCommandRepository : IMembershipCommandRepository
    {
        private readonly ConcurrentBag<Membership> members;

        public InMemoryMembershipCommandRepository()
        {
            members = new ConcurrentBag<Membership>();
        }
        public void AddMembership(CreateMemberCommand request)
        {
            members.Add(new Membership
            {
                Mail = request.Mail,
                PhoneNumber = request.PhoneNumber,
                IdentityCard = new IdentityCard
                {
                    Birthday = request.IdentityBirthday,
                    CardNumber = request.IdentityCardNumber,
                    FirstName = request.IdentityFirstName,
                    LastName = request.IdentityLastName,
                    NISS = request.NISS,
                    ValidityDate = request.IdentityValidityDate
                }
            });
        }

      

        public Task<Membership> GetById(long id)
        {
             return Task.FromResult(members.FirstOrDefault(m => m.Id == id));
        }

        public Task<Membership> GetByMailOrPhoneNumber(string mail, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateMembership(UpdateMemberCommand request)
        {
            throw new NotImplementedException();
        }
    }
}