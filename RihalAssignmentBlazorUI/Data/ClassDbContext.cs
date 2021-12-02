using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Data
{
    public class ClassDbContext : DbContext
    {
            #region Contructor
            public ClassDbContext(DbContextOptions<ClassDbContext> options)
                    : base(options)
            {
                Database.EnsureCreated();
            }
            #endregion

            #region Public properties
            public DbSet<DomainClass> Class { get; set; }
            #endregion

            #region Overidden methods
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<DomainClass>().HasData(GetCalsses());
                base.OnModelCreating(modelBuilder);
            }
            #endregion


            #region Private methods
            private List<DomainClass> GetCalsses()
            {
                return new List<DomainClass>
            {
                new DomainClass { Id = 1001, Name = "Grade 1"},
                new DomainClass { Id = 1002, Name = "Grade 2"},
                new DomainClass { Id = 1003, Name = "Grade 3"},
                new DomainClass { Id = 1004, Name = "Grade 4"}
            };
            }
            #endregion
        }
}
