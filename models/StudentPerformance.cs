using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeSystemDB.models
{
    public class StudentPerformance
    {
        [Key]
        public int PerformanceId { get; set; }

        public double Grade { get; set; }
        public int AttendancePercentage { get; set; }
        public int CreditsEarned { get; set; }

        // Foreign keys and navigation properties
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }

    }
}
