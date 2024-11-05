using employeeCompantDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace collegeSystemDB.models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }
        public int Credits { get; set; }

        // Foreign key and navigation property to primary Department
        [ForeignKey("PrimaryDepartment")]
        public int DepartmentId { get; set; }
        public Department PrimaryDepartment { get; set; }

        // Navigation properties
        public ICollection<Class> Classes { get; set; }

    }
}
