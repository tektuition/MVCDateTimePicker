using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDateTimePicker.Models;

namespace WebDateTimePicker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentModel objStudentModel = new StudentModel()
            {
                FromDate = DateTime.Now,
                ToDate = DateTime.Now.AddDays(1)
            };
            return View(objStudentModel);
        }

        [HttpPost]
        public ActionResult Index(StudentModel objStudentModel)
        {
            return Content(((objStudentModel.ToDate - objStudentModel.FromDate).TotalDays).ToString());
        }
    }
}