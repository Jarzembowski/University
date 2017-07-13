using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.DAL;
using University.ViewModels;

namespace University.Controllers
{
   public class HomeController : Controller
   {
      private SchoolContext db = new SchoolContext();

      public ActionResult Index()
      {
         return View();
      }

      public ActionResult About()
      {
         IQueryable<EnrollmentDateGroup> data = from enrollment in db.Enrollments                                                
                                                group enrollment by enrollment.CourseID into dateGroup
                                                join _C in db.Courses on dateGroup.FirstOrDefault().CourseID equals _C.CourseID
                                                select new EnrollmentDateGroup()
                                                {
                                                   CourseTitle = dateGroup.FirstOrDefault().Course.Title,
                                                   StudentCount = dateGroup.Count()
                                                };
         return View(data.ToList());
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }
   }
}