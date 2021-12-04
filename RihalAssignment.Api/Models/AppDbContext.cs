using Microsoft.EntityFrameworkCore;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
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
        public DbSet<Country> Countries { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(GetCountries());
            modelBuilder.Entity<Class>().HasData(GetCalsses());
            modelBuilder.Entity<Student>().HasData(GetStudents());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country { Id = 1, Name = "Oman"},
                new Country { Id = 2, Name = "India"},
                new Country { Id = 3, Name = "Pakistan"},
                new Country { Id = 4, Name = "Egypt"}
            };
        }
        private List<Class> GetCalsses()
        {
            return new List<Class>
            {
                new Class { Id = 1, Name = "Grade 1"},
                new Class { Id = 2, Name = "Grade 2"},
                new Class { Id = 3, Name = "Grade 3"},
                new Class { Id = 4, Name = "Grade 4"}
            };
        }
        private List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1001, Name = "test1", ClassId = 1, CountryId = 1},
                new Student { Id = 1002, Name = "test2", ClassId = 1, CountryId = 1},
                new Student { Id = 1003, Name = "test3", ClassId = 1, CountryId = 1},
                new Student { Id = 1004, Name = "test4", ClassId = 1, CountryId = 1}
            };
        }
        #endregion
    }
}
