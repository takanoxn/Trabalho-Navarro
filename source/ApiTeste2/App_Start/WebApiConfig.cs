using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;

namespace ApiTeste2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;

            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{codigo}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
