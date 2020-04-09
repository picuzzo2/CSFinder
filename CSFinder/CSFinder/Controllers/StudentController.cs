using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSFinder.Models;
using Microsoft.AspNetCore.Http;

namespace CSFinder.Controllers
{
    public class StudentController : Controller
    {
        private CSFinderContext db;
        public StudentController(CSFinderContext _db)
        {
            db = _db;
        }

        public IActionResult StudentDashBoard()
        {
            ViewBag.UserID = HttpContext.Session.GetString("UserID");
            ViewBag.IDType = HttpContext.Session.GetString("IDType");
            ViewBag.SID = HttpContext.Session.GetString("SID");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Status = HttpContext.Session.GetString("Status");
            return View();
        }
        
        public IActionResult History()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.studentName = "Anicha";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","RegisLogin");
        }
        public IActionResult Register()
        {
            return View();
        }



    }
}
