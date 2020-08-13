using KWLeLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace KWLeLearning.Controllers
{
    public class StudentController: Controller
    {
        [Authorize(Roles ="Teacher")]
        public ActionResult Details()
        {
            var studentDetails = new ApplicationDbContext();
            return View(studentDetails.Student.OrderBy(m => m.Team).ToList());
        }


    }

    
}