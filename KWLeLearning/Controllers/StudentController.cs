using KWLeLearning.Models;
using Microsoft.Ajax.Utilities;
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

        // GET: Student/Edit
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var student = new ApplicationDbContext();
            var result = student.Student.Where(m => m.Id == Id).FirstOrDefault();


            return View(result);
        }
        // POST: Student/Edit
        [HttpPost]
        public ActionResult Edit(Student student)
        {

            var studentEdit = new ApplicationDbContext();
            var result = studentEdit.Student.Where(m => m.Id == student.Id).FirstOrDefault();

            studentEdit.Student.Remove(result);
            studentEdit.Student.Add(student);

            studentEdit.SaveChanges();


            return View("Details", studentEdit.Student.OrderBy(m => m.Team).ToList());
        }


    }

    
}