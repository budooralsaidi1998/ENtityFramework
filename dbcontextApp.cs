using collegeSystemDB.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace collegeSystemDB
{
    public  class dbcontextApp:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(" Data Source=(local); Initial Catalog=CollegeDB; Integrated Security=true; TrustServerCertificate=True ");
        }


        public DbSet<Faculty> Facultys { get; set; }
        public DbSet<Class> Classs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<StudentPerformance> StudentPerformances { get; set; }

    }


}
