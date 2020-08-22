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
        // GET: Know Team
        public ActionResult Know(string password, string username)
        {
            var db = new ApplicationDbContext();
            var result = db.Student.Where(m => m.Password == password).FirstOrDefault();

            var dbTeam = new ApplicationDbContext();
            var team = dbTeam.Student.Where(m => m.Team == result.Team).ToList();

            return View(team);
        }

        // GET: What Team
        public ActionResult What(string password, string username)
        {
            var db = new ApplicationDbContext();
            var result = db.Student.Where(m => m.Password == password).FirstOrDefault();

            var dbTeam = new ApplicationDbContext();
            var team = dbTeam.Student.Where(m => m.Team == result.Team).ToList();

            return View(team);
        }

        // GET: Learned Team
        public ActionResult Learned(string password, string username)
        {
            var db = new ApplicationDbContext();
            var result = db.Student.Where(m => m.Password == password).FirstOrDefault();

            var dbTeam = new ApplicationDbContext();
            var team = dbTeam.Student.Where(m => m.Team == result.Team).ToList();

            return View(team);
        }
    }
}