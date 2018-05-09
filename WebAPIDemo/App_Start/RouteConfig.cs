using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAPIDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employees", action = "GetAll", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "ById",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Employees", action = "GetById", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "ByName",
               url: "{controller}/{action}/{term}",
               defaults: new { controller = "Employees", action = "GetByFn", term = UrlParameter.Optional }
           );
        }
    }
}
