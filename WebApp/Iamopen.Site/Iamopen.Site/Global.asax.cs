﻿using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using IAmOpen.Site.Model.Concrete.Database;
using IAmOpen.Site.Model.Initialization;
using Iamopen.Availability.OnlineAvailability.Implementation;

namespace Iamopen.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Institution", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Database.SetInitializer<InstitutionContext>(new InstitutionInitializer());
            
            OnlineAvailabilityManager.Init();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}