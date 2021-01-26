using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMany2ManyDemoConsole.Data.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}

