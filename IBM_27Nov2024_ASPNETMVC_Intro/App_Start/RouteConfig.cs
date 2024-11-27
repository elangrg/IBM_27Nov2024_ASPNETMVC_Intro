using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IBM_27Nov2024_ASPNETMVC_Intro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                //       Home/index/1000
                //employee/find/1000
                defaults: new { controller = "product", action = "Index" }
            );

            routes.MapRoute(
                name: "",
                url: "{controller}/{action}/{id}",
                //       Home/index/1000
                //employee/find/1000
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
