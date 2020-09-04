using MembershipDisco.Business.Interfaces;
using MembershipDisco.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MembershipDisco.Persistance.Repositories
{
    public class MembershipQueryRepository: IMembershipQueryRepository
    {
        private readonly MembershipDiscoContext _DbContext;

        public MembershipQueryRepository(MembershipDiscoContext dbContext)
        {
            _DbContext = dbContext;
        }
    }
}