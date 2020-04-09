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

        public IActionResult UserDashBoard()
        {
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

        public IActionResult test()
        {
            return View();
        }

    }
}
