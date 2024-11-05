using employeeCompantDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeSystemDB.models
{
   
    
        public class Department
        {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        // Navigation properties
        public ICollection<Faculty> Faculties { get; set; }
        public ICollection<Program> Programs { get; set; }

    }
}
