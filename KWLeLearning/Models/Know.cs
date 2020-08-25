using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KWLeLearning.Models
{
    public class Know
    {
        [Key]
        public int Id { get; set; }

        public string KnowPassword { get; set; }

        public string KnowComment { get; set; }

        public string KnowColour { get; set; }
    }
}