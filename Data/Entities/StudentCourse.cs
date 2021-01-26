﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreMany2ManyDemoConsole.Data.Entities
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        //[Column("ReallyCoolCourseId")]
        public int CourseId { get; set; }
        public DateTime Created { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
