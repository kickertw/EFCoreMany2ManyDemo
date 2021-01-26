using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreMany2ManyDemoConsole.Data;
using EFCoreMany2ManyDemoConsole.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMany2ManyDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedData();
            var students = GetStudents();

            foreach (var student in students)
            {
                var courseList = string.Join(',', student.Courses.Select(i => i.Title));
                Console.WriteLine($"{student.Name} is in courses [{courseList}]");
            }
        }

        static List<Student> GetStudents()
        {
            using var db = new MyContext();
            return db.Students
                .Include(i => i.Courses)
                .ToList();
        }

        static void SeedData()
        {
            using var db = new MyContext();
            if (db.Students.Any())
            {
                return;
            }

            var seedStudents = new List<Student>
            {
                new Student
                {
                    Name = "Hope"
                },
                new Student
                {
                    Name = "Faith"
                },
                new Student
                {
                    Name = "Grace"
                }
            };

            var seedCourses = new List<Course>
            {
                new Course
                {
                    Title = "Discrete Mathematics"
                },
                new Course
                {
                    Title = "Relational Databases"
                },
                new Course
                {
                    Title = "Intro to Comp Sci"
                },
            };

            seedStudents[0].Courses = seedCourses;
            seedStudents[1].Courses = seedCourses.GetRange(1, 2);
            seedStudents[2].Courses = seedCourses.GetRange(2, 1);

            db.Students.AddRange(seedStudents);
            db.Courses.AddRange(seedCourses);
            db.SaveChanges();
        }
    }
}
