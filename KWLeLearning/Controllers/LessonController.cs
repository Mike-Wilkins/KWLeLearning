using KWLeLearning.Migrations;
using KWLeLearning.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        public ActionResult Know(string password, string team)
        {
            var db = new ApplicationDbContext();

            // Get KnowCount from db

            var commentCount = db.Student.Where(m => m.Password == password).FirstOrDefault();
            var sum = commentCount.KnowCount;

            // Check KnowCount is less than or equal to 3
            // Is less than three only show student comments
            // Update student db KnowCounter
            var student = new Student();

            if(sum <= 1)
            {
                var result = db.Student.Where(m => m.Password == password).FirstOrDefault();
                var model = new LessonViewModel
                {
                    Students = kwlDb.Student.OrderByDescending(m => m.IsLoggedIn == true).Where(m => m.Team == result.Team).ToList(),
                    Knows = kwlDb.Know.Where(m => m.KnowPassword == password).ToList()
                };
                return View(model);
            }
            // Is counter is greater than three show student TEAM comments

            var teamResult = db.Student.Where(m => m.Password == password).FirstOrDefault();
            var teammodel = new LessonViewModel
            {
                Students = kwlDb.Student.OrderByDescending(m => m.IsLoggedIn == true).Where(m => m.Team == teamResult.Team).ToList(),
                Knows = kwlDb.Know.OrderByDescending(m => m.Id).Where(m => m.Team == team).ToList()
            };

            return View(teammodel);
        }

        [HttpPost]
        // POST: Know/ KnowComment
        public ActionResult Know(LessonViewModel comment, string password, string colour, string team)
        {

            // Save Know comment to db
            var db = new ApplicationDbContext();
            var knowComment = new Know();

            knowComment.KnowComment = comment.KnowComment;
            knowComment.KnowPassword = password;
            knowComment.KnowColour = colour;
            knowComment.Team = team;
            

            db.Know.Add(knowComment);
            db.SaveChanges();
            ModelState.Clear();

            // Get KnowCount from db

            var commentCount = db.Student.Where(m => m.Password == password).FirstOrDefault();
            var sum = commentCount.KnowCount;



            // Check KnowCount is less than or equal to 3
            // Is less than three only show student comments
            // Update student db KnowCounter
            var student = new Student();
           
            if (sum <= 1)
            {

                var result = db.Student.Where(m => m.Password == password).FirstOrDefault();
                var model = new LessonViewModel
                    {
                        Students = kwlDb.Student.OrderByDescending(m => m.IsLoggedIn == true).Where(m => m.Team == result.Team).ToList(),
                        Knows = kwlDb.Know.Where(m => m.KnowPassword == password).ToList()
                    };

                var studentEdit = new ApplicationDbContext();
                var resultEdit = studentEdit.Student.Where(m => m.Password == password).FirstOrDefault();

                studentEdit.Student.Remove(resultEdit);

                student.Firstname = result.Firstname;
                student.Surname = result.Surname;
                student.Username = result.Username;
                student.Password = result.Password;
                student.Team = result.Team;
                student.IsLoggedIn = result.IsLoggedIn;
                student.Email = result.Email;
                student.Colour = result.Colour;
                student.KnowCount = result.KnowCount + 1;

                studentEdit.Student.Add(student);
                studentEdit.SaveChanges();

                return View(model);

            }

            // Is counter is greater than three show student TEAM comments
         
            var teamResult = db.Student.Where(m => m.Password == password).FirstOrDefault();
            var teammodel = new LessonViewModel
            {
                Students = kwlDb.Student.OrderByDescending(m => m.IsLoggedIn == true).Where(m => m.Team == teamResult.Team).ToList(),
                Knows = kwlDb.Know.OrderByDescending(m => m.Id).Where(m => m.Team == team).ToList()
            };


            return View(teammodel);

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