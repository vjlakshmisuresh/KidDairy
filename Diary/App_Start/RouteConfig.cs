using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Diary
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Home", id = UrlParameter.Optional });
            routes.MapRoute(
                name: "Food",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Food", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(
               name: "Activity",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Activity", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(
               name: "Sleep",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Sleep", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(
               name: "Diapers",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Diapers", action = "Index", id = UrlParameter.Optional });

        }
    }
}
