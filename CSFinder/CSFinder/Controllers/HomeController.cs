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
    
    public class HomeController : Controller
    {
        private CSFinderContext db;
        public HomeController(CSFinderContext _db)
        {
            db = _db;
        }
        public IActionResult Login()
        {
            Debug.WriteLine("Debug Login");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Account objUser)
        {
            
            if (ModelState.IsValid)
            {
                
                var obj = db.Accounts.Where(a => a.ID.Equals(objUser.ID) && a.Password.Equals(objUser.Password)).FirstOrDefault();

                if (obj != null)
                {
                    HttpContext.Session.SetString("UserID", obj.ID.ToString()) ;
                    HttpContext.Session.SetString("IDType", obj.IDtype.ToString());
                    return RedirectToAction("UserDashBoard");
                }
                
            }
            return View(objUser);
        }

        public IActionResult UserDashBoard()
        {
            string userID = HttpContext.Session.GetString("UserID");
            string IDType = HttpContext.Session.GetString("IDType");
            if (IDType != null)
            {

                if(IDType == "Student")
                {
                    var obj = db.Students.Where(a => a.ID.Equals(HttpContext.Session.GetString("UserID"))).FirstOrDefault();
                    ViewBag.SID = obj.SID.ToString();
                    ViewBag.Name = obj.Name.ToString();
                    ViewBag.Status = obj.Status.ToString();
                }
                else if(IDType == "Company")
                {
                    var obj = db.Companies.Where(a => a.ID.Equals(HttpContext.Session.GetString("UserID"))).FirstOrDefault();

                }
                    
                ViewBag.UserID = HttpContext.Session.GetString("UserID");
                ViewBag.IDType = HttpContext.Session.GetString("IDType");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
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
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

    }
}
