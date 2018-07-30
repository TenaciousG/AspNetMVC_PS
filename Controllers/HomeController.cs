using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC_PS.Models;

namespace DemoMVC_PS.Controllers
{
    public class HomeController : Controller
    {
        // site/home/index
        public ActionResult Index()
        {
            return View();
        }

        // site/home/about
        public ActionResult About()
        {
            ViewBag.Message = string.Empty;

            return View();
        }

        [HttpPost]
        public ActionResult About(string userData)
        {
            ViewBag.Message = userData;
            return View();
        }

        // site/home/contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // site/home/list
        public ActionResult List()
        {
            return View(TechItemFetcher.GetItems());
        }
    }
}