using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BaiThiASP.Models;
namespace BaiThiASP
{
    public class DataContext : DbContext
    {
        public DataContext() : base("BaiThiASP")
        {
        }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public System.Data.Entity.DbSet<BaiThiASP.Models.Classroom> Classrooms { get; set; }

        public System.Data.Entity.DbSet<BaiThiASP.Models.Falculty> Falculties { get; set; }
    }
}