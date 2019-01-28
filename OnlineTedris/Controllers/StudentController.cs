using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTedris.Context;
using OnlineTedris.Models.DbModels;

namespace OnlineTedris.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        DbTraining dbTraining = new DbTraining();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult RegisterStudent(Telebe telebe)
        {
            if(telebe.ID==0)
            {
                dbTraining.Telebes.Add(telebe);
            }
            dbTraining.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}