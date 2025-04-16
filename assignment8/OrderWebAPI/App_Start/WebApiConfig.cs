using System.Web.Http;
using System.Web.Http.Cors;

namespace OrderWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // 启用跨域
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // 属性路由
            config.MapHttpAttributeRoutes();

            // 约定路由
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 设置JSON为默认格式
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
