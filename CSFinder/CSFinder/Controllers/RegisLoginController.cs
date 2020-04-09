using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CSFinder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSFinder.Controllers
{
    public class RegisLoginController : Controller
    {
        private CSFinderContext db;
        public RegisLoginController(CSFinderContext _db)
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
                    HttpContext.Session.SetString("UserID", obj.ID.ToString());
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

                if (IDType == "Student")
                {
                    var obj = db.Students.Where(a => a.ID.Equals(HttpContext.Session.GetString("UserID"))).FirstOrDefault();
                    ViewBag.SID = obj.SID.ToString();
                    ViewBag.Name = obj.Name.ToString();
                    ViewBag.Status = obj.Status.ToString();
                }
                else if (IDType == "Company")
                {
                    var obj = db.Companies.Where(a => a.ID.Equals(HttpContext.Session.GetString("UserID"))).FirstOrDefault();

                }

                ViewBag.UserID = HttpContext.Session.GetString("UserID");
                ViewBag.IDType = HttpContext.Session.GetString("IDType");
                return RedirectToAction("UserDashBoard","StudentHomeController");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}