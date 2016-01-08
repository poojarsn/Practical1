using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;

namespace MvcApplication1.App_Start
{
    public class RegisterWebApiRoute
    {
        public void Process(PipelineArgs args)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        public void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Only JSON response
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            /*
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            */
        }
    }
}