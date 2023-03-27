using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NguyenngocthanhThanh_2080600664_20DTHD3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
