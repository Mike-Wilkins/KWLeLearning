using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KWLeLearning.Models
{
    public class LessonViewModel
    {

        public IEnumerable<Student> Students { get; set; }

        public IEnumerable<Know> Knows { get; set; }

        public string KnowComment { get; set; }

        public int KnowCommentCount { get; set; }
    }
}