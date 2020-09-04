using MembershipDisco.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MembershipDisco.Persistance.Data
{  
    public class MembershipDiscoContext : DbContext
    {
    
        public MembershipDiscoContext() : base("MembershipDiscoContext")
        {
        }

        public DbSet<MembershipCard> MemberShipCards { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<IdentityCard> IdentityCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityCard>()
            .HasIndex(u => u.CardNumber)
            .IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}