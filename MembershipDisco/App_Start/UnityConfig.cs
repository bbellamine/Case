using MembershipDisco.Business.Interfaces;
using MembershipDisco.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.AspNet.Mvc;

namespace MembershipDisco.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterDependencies()
        {  
            var container = new UnityContainer();
            container.RegisterType<IMembershipCommandRepository, MembershipCommandRepository>(new PerRequestLifetimeManager());
            System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}