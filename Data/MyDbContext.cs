using EFCoreMany2ManyDemoConsole.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace EFCoreMany2ManyDemoConsole.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=.;Database=EFDemoDB;Trusted_Connection=True;Integrated Security=true;MultipleActiveResultSets=true");


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //}
    }
}
