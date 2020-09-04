using MembershipDisco.Business.Interfaces;
using MembershipDisco.Business.Member.Commands;
using MembershipDisco.Persistance.Data;
using MembershipDisco.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace MembershipDisco.Persistance.Repositories
{
    public class MembershipCommandRepository : IMembershipCommandRepository
    {
        private readonly MembershipDiscoContext _DbContext;

        public MembershipCommandRepository(MembershipDiscoContext dbContext)
        {
            _DbContext = dbContext;
        }

        public void AddMembership(CreateMemberCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<Membership> GetById(long id)
        {
            return _DbContext.Memberships.Include(p => p.IdentityCard).FirstOrDefaultAsync(m => m.Id == id);
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