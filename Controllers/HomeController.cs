using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace canome0._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What are we about.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact developers.";

            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult Filter()
        {
            return View();
        }

        public ActionResult profileCreation()
        {
            return View();
        }

        public ActionResult profile()
        {
            return View();
        }

        public ActionResult PostAd()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult House()
        {
            return View();
        }

        public ActionResult Apartments()
        {
            return View();
        }

        public ActionResult Condos()
        {
            return View();
        }

        public ActionResult ViewAds()
        {
            return View();
        }
    }

}

