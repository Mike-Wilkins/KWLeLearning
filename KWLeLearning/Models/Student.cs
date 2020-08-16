using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KWLeLearning.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

       
        public string Email { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

       
        public string Team { get; set; }
        public bool IsLoggedIn { get; set; }

    }
}