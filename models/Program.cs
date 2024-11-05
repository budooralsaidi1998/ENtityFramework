using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeSystemDB.models
{
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public int DurationYears { get; set; }
        public string DegreeAwarded { get; set; }

        // Foreign key and navigation property to Department
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        // Navigation properties
        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
