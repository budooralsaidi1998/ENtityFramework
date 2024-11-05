using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeSystemDB.models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        public string Schedule { get; set; }
        public string RoomLocation { get; set; }

        // Foreign key and navigation properties
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        // Navigation property
        public ICollection<StudentPerformance> StudentPerformances { get; set; }


    }
}
