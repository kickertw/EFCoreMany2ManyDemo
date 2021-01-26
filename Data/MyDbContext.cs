using EFCoreMany2ManyDemoConsole.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace EFCoreMany2ManyDemoConsole.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=.;Database=EFDemoDB;Trusted_Connection=True;Integrated Security=true;MultipleActiveResultSets=true");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(i => i.Courses)
                .WithMany(i => i.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentCourse",
                    i => i.HasOne<Course>().WithMany(),
                    i => i.HasOne<Student>().WithMany());
        }
    }
}
