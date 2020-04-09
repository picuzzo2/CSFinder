using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSFinder.Models;

namespace CSFinder.Controllers
{
    [Route("Student")]
    public class StudentController : Controller
    {

        private CSFinderContext db;
        public StudentController(CSFinderContext _db)
        {
            db = _db;
        }
        
        [Route("Details")]
        public IActionResult Details()
        {
            ViewBag.students = db.Students.ToList();
            return View();
        }
        [Route("Home")]
        public IActionResult Home()
        {
            return View();
        }
        [Route("Profile")]
        public IActionResult Profile()
        {
            return View();
        }
        [Route("History")]
        public IActionResult History()
        {
            return View();
        }
        [Route("Logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}