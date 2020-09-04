using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MembershipDisco.Persistance.Models
{
    public class Membership
    {
        public long Id { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("IdentityCard")]
        public long IdentityCardId { get; set; }

         public IdentityCard IdentityCard { get; set; }
    }
}