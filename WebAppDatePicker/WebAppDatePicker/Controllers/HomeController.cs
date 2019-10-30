using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppDatePicker.Models;

namespace WebAppDatePicker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentModel objStudentModel = new StudentModel()
            {
                DateOfBirth = DateTime.Now
            };
            return View(objStudentModel);
        }
    }
}