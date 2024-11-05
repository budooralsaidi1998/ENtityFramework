using employeeCompantDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeSystemDB.models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        public DateTime DateOfEnrollment { get; set; }
        public string Status { get; set; }

        // Foreign key and navigation properties
        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public Program Program { get; set; }

        [ForeignKey("FacultyAdvisor")]
        public int FacultyAdvisorId { get; set; }
        public Faculty FacultyAdvisor { get; set; }

        // Navigation properties
        public ICollection<StudentPerformance> StudentPerformances { get; set; }
    }
}
