using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Data
{
    public class CountryDbContext : DbContext
    {
            #region Contructor
            public CountryDbContext(DbContextOptions<CountryDbContext> options)
                    : base(options)
            {
                Database.EnsureCreated();
            }
            #endregion

            #region Public properties
            public DbSet<Country> Country { get; set; }
            #endregion

            #region Overidden methods
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Country>().HasData(GetCalsses());
                base.OnModelCreating(modelBuilder);
            }
            #endregion


            #region Private methods
            private List<Country> GetCalsses()
            {
                return new List<Country>
            {
                new Country { Id = 1001, Name = "Oman"},
                new Country { Id = 1002, Name = "India"},
                new Country { Id = 1003, Name = "Pakistan"},
                new Country { Id = 1004, Name = "Egypt"}
            };
            }
            #endregion
        }
}
