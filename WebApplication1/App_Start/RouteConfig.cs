using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //Задание 1: домашний маршрут
            routes.MapRoute(
                name: "localhost",
                url: "",
                defaults: new { controller = "Home", action = "Products" }
            );

            //Задание 2: маршрут \product\xxx
            routes.MapRoute(
                name: "product1",
                url: "product/{name}",
                defaults: new { controller = "Product", action = "Index", name = "AS-009" },
                   constraints: new { name = "[A-Z]{2}-[0-9]{3}" }
                );

            //Задание 3: маршрут \product\xxx\print
            routes.MapRoute(
                name: "product2",
                url: "product/{name}/print",
                defaults: new { controller = "Product", action = "Print", name = "AS-009" },
                   constraints: new { name = "[A-Z]{2}-[0-9]{3}" }
                );


            //Задание 5: маршрут \products\date\xx-xx-xxxx\yy (где xx-xx-xxxx - валидная дата, yy - номер страницы - по умолчанию 1)
            routes.MapRoute(
              name: "product4",
              url: "products/date/{validDate}/{page}",
              defaults: new { controller = "Product", action = "Date", validDate = "01-01-2015", page = "1" },
                 constraints: new
                 {
                     //validDate = @"(0[1-9]|[12][0-9]|3[01])[- .](0[1-9]|1[012])[- .](19|20)\d\d",
                     validDate = new validDateConstraint(),
                     page = @"\d+"
                 }
              );

            //Задание 4: маршрут \products\xxx\yy (где xxx - название категории, yy - номер страницы - по умолчанию 1)
            routes.MapRoute(
              name: "product3",
              url: "products/{category}/{page}",
              defaults: new { controller = "Product", action = "Category", category = "sport", page = "1" },
                 constraints: new
                 {
                     category = "[a-z]+",
                     page = @"\d+"
                 }
              );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
