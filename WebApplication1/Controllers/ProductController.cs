using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            ViewBag.myText = "Задание 2: маршрут /product/AB-132";
            ViewBag.myTitle = "Product";
            return View();
        }

        public ActionResult Print()
        {
            ViewBag.myText = "Задание 3: маршрут /product/AB-132/print";
            return View();
        }

        public ActionResult Category()
        {
            ViewBag.myText = "Задание 4: маршрут /products/category/page";
            return View();
        }

        public ActionResult Date()
        {
            ViewBag.myText = "Задание 5: маршрут /products/date/xx-xx-xxxx/yy";
            return View();
        }
	}
}