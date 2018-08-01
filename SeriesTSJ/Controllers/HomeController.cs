using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return Redirect("Series");
        }

        public ActionResult About() {
            ViewBag.Message = "Hola mateo como estas";
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}