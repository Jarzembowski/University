using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using University.Models;


namespace University.ViewModels
{
   public class EnrollmentDateGroup
   {      
      public string CourseTitle { get; set; }
      public int StudentCount { get; set; }
      
   }
}