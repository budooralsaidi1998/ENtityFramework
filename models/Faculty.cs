using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeSystemDB.models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Rank { get; set; }

        public DateTime DateOfEmployment { get; set; }

        // Foreign key and navigation property to Department
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        // Navigation properties
        public ICollection<Class> Classes { get; set; }
        public ICollection<Student> Advisees { get; set; }
    }
}
