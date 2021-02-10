using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            routes.MapRoute(
                name:"Todas as notícias",
                url: "noticias/",
                defaults: new { controller = "Home", action = "TodasAsNoticias" }
                );

            routes.MapRoute(
                name: "noticia",
                url: "noticia/",
                defaults: new { controller = "Home", action = "MostrarNoticia" }
                );

            routes.MapRoute(
               name: "Categoria Específica",
               url: "noticiais/{categoria}",
               defaults: new { controller = "Home", action = "MostrarCategoria" }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
