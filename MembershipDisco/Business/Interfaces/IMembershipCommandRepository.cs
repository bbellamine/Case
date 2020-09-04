using MembershipDisco.Business.Member.Commands;
using MembershipDisco.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MembershipDisco.Business.Interfaces
{
    public interface IMembershipCommandRepository
    {
        Task<Membership> GetByMailOrPhoneNumber(string mail, string phoneNumber);
        void AddMembership(CreateMemberCommand request);
        Task<Membership> GetById(long id);
        void UpdateMembership(UpdateMemberCommand request);
    }
}