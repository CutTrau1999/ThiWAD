using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BaiThiASP.Models
{
    public class Classroom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}