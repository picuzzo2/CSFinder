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
        
        public IActionResult Details()
        {
            ViewBag.students = db.Students.ToList();
            return View();
        }
    }
}