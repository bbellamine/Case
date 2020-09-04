using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MembershipDisco.Persistance.Models
{
    public class IdentityCard
    {
        public long Id { get; set; }

    
        public string FirstName { get; set; }


        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

    
        public string NISS { get; set; }
        public DateTime ValidityDate { get; set; }
        public DateTime ExpirationDate { get; set; }     
        public long CardNumber { get; set; }
        public bool Expired { get; set; }
        public bool Renewed { get; set; }
    }
}