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

        private ApplicationDbContext kwlDb = new ApplicationDbContext();


        [Authorize]
        // GET: Know Team
        public ActionResult Know(string password)
        {
            var db = new ApplicationDbContext();
            var result = db.Student.Where(m => m.Password == password).FirstOrDefault();

            var model = new LessonViewModel
            {
                Students = kwlDb.Student.Where(m => m.Team == result.Team).ToList(),
                Knows = kwlDb.Know.Where(m => m.KnowPassword == password).ToList()

            };
            return View(model);
        }

        [HttpPost]
        // POST: Know/ KnowComment
        public ActionResult Know(LessonViewModel comment, string password, string colour)
        {
            var db = new ApplicationDbContext();
            var knowComment = new Know();

            knowComment.KnowComment = comment.KnowComment;
            knowComment.KnowPassword = password;
            knowComment.KnowColour = colour;

            db.Know.Add(knowComment);
            db.SaveChanges();
            ModelState.Clear();

           
            var result = db.Student.Where(m => m.Password == password).FirstOrDefault();
            var model = new LessonViewModel
            {
                Students = kwlDb.Student.Where(m => m.Team == result.Team).ToList(),
                Knows = kwlDb.Know.Where(m => m.KnowPassword == password).ToList()

            };

            return View(model);
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