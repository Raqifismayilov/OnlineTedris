using OnlineTedris.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineTedris.Controllers
{
    public class HomeController : Controller
    {
        DbTraining db = new DbTraining();
        public ActionResult Index()
        {
            return View(db.Telebes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RegisterStudent()
        {
            ViewBag.Message = "Register page.";

            return View();
        }
    }
}