using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationQuiMeRessemble.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Cette page parle de moi";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Voici où j'habite";

            return View();
        }
        public ActionResult Hobbies()
        {
            ViewBag.Message = "Et voilà mes hobbies et passions";

            return View();
        }
    }
}