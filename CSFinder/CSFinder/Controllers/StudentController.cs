using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSFinder.Models;
using Microsoft.AspNetCore.Http;

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
            string userID = HttpContext.Session.GetString("UserID");
            string IDType = HttpContext.Session.GetString("IDType");
            if (IDType != null)
            {

                if (IDType == "Student")
                {
                    var obj = db.Students.Where(a => a.ID.Equals(HttpContext.Session.GetString("UserID"))).FirstOrDefault();
                    ViewBag.Name = obj.Name.ToString();
                    ViewBag.Status = obj.Status.ToString();
                }                
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

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