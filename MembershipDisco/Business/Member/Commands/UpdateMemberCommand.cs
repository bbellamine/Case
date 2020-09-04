using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MembershipDisco.Business.Member.Commands
{
    public class UpdateMemberCommand : IRequest<bool>
    {
        public long Id { get; set; }

        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityFirstName { get; set; }
        public string IdentityLastName { get; set; }
        public DateTime IdentityBirthday { get; set; }
        public string NISS { get; set; }
        public DateTime IdentityValidityDate { get; set; }
        public DateTime IdentityExpirationDate { get; set; }
        public long IdentityCardNumber { get; set; }
    }
}