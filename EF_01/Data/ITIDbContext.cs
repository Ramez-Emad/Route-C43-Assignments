using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Data
{
    internal class ITIDbContext : DbContext
    {

        public DbSet<Models.Course> Course { get; set; }
        public DbSet<Models.Course_Inst> Course_Inst { get; set; }
        public DbSet<Models.Department> Department { get; set; }
        public DbSet<Models.Instructor> Instructor { get; set; }
        public DbSet<Models.Stud_Course> Stud_Course { get; set; }
        public DbSet<Models.Student> Student { get; set; }
        public DbSet<Models.Topic> Topic { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate = True");
        }
    }
}
