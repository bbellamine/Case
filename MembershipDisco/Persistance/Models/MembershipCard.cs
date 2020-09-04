using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MembershipDisco.Persistance.Models
{
    public class MembershipCard
    {
        public long Id { get; set; }
        public long CardNumber { get; set; }
        public bool Lost { get; set; }

        [ForeignKey("Member")]
        public long MemberId { get; set; }
        public Membership Member { get; set; }
        public DateTime UnblacklistDate { get; set; }
    }
}