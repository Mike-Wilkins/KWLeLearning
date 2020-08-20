using KWLeLearning.Migrations;
using KWLeLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KWLeLearning.Controllers
{
    public class LessonController: Controller
    {
        [Authorize]
        // GET: KWL Team
        public ActionResult KWL(string password, string username)
        {
            var db = new ApplicationDbContext();
            var result = db.Student.Where(m => m.Password == password).FirstOrDefault();

            var dbTeam = new ApplicationDbContext();
            var team = dbTeam.Student.Where(m => m.Team == result.Team).ToList();

            return View(team);
        }


    }
}