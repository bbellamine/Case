using MembershipDisco.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MembershipDisco
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {          
            GlobalConfiguration.Configure(WebApiConfig.Register);
            UnityConfig.RegisterDependencies();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes); 
            
        }
    }
}
