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
        #region Contstructor
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        { 
            //Database.EnsureCreated();
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
            OrganizationDBInitializer organizationData = new OrganizationDBInitializer();
            modelBuilder.Entity<Country>().HasData(organizationData.Countries);
            modelBuilder.Entity<Class>().HasData(organizationData.Classes);
            modelBuilder.Entity<Student>().HasData(organizationData.Students);
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}