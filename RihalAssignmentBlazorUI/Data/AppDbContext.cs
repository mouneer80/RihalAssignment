using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Data
{
    public class AppDbContext : DbContext
    {
        #region Contructor
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<Country> Country { get; set; }
        public DbSet<ClassOfDomain> Class { get; set; }
        public DbSet<Student> Student { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(GetCountries());
            modelBuilder.Entity<ClassOfDomain>().HasData(GetCalsses());
            modelBuilder.Entity<Student>().HasData(GetStudents());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country { Id = 1001, Name = "Oman"},
                new Country { Id = 1002, Name = "India"},
                new Country { Id = 1003, Name = "Pakistan"},
                new Country { Id = 1004, Name = "Egypt"}
            };
        }
        private List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1001, Name = "test1"},
                new Student { Id = 1002, Name = "test2"},
                new Student { Id = 1003, Name = "test3"},
                new Student { Id = 1004, Name = "test4"}
            };
        }
        private List<ClassOfDomain> GetCalsses()
        {
            return new List<ClassOfDomain>
            {
                new ClassOfDomain { Id = 1001, Name = "Grade 1"},
                new ClassOfDomain { Id = 1002, Name = "Grade 2"},
                new ClassOfDomain { Id = 1003, Name = "Grade 3"},
                new ClassOfDomain { Id = 1004, Name = "Grade 4"}
            };
        }
        #endregion
    }
}
