using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BaiThiASP.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string StartTime { get; set; }

        public string Date { get; set; }

        public string Duration { get; set; }
        public string Classroom { get; set; }

        public string Faculty { get; set; }
        public string Status { get; set; }

      


    }
}