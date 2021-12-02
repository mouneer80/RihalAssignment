using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Data
{
    public class ClassesServices
    {
        #region Private members
        private ClassDbContext dbContext;
        #endregion

        #region Constructor
        public ClassesServices(ClassDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of classes
        /// </summary>
        /// <returns></returns>
        public async Task<List<DomainClass>> GetClassAsync()
        {
            return await dbContext.Class.ToListAsync();
        }

        /// <summary>
        /// This method add a new Class to the DbContext and saves it
        /// </summary>
        /// <param name="class"></param>
        /// <returns></returns>
        public async Task<DomainClass> AddClassAsync(DomainClass Class)
        {
            try
            {
                dbContext.Class.Add(Class);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Class;
        }

        /// <summary>
        /// This method update and existing Class and saves the changes
        /// </summary>
        /// <param name="class"></param>
        /// <returns></returns>
        public async Task<DomainClass> UpdateClassAsync(DomainClass Class)
        {
            try
            {
                var ClassExist = dbContext.Class.FirstOrDefault(p => p.Id == Class.Id);
                if (ClassExist != null)
                {
                    dbContext.Update(Class);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Class;
        }

        /// <summary>
        /// This method removes and existing Class from the DbContext and saves it
        /// </summary>
        /// <param name="class"></param>
        /// <returns></returns>
        public async Task DeleteClassAsync(DomainClass Class)
        {
            try
            {
                dbContext.Class.Remove(Class);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
