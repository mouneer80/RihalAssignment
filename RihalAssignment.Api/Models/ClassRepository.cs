using Microsoft.EntityFrameworkCore;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
{
    public class ClassRepository : IClassRepository
    {
        #region Private members
        private readonly AppDbContext appDbContext;
        #endregion

        #region Constructor
        public ClassRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        #endregion

        #region Public methods
        public async Task<IEnumerable<Class>> GetClasses()
        {
            return await appDbContext.Classes.ToListAsync();
        }
        public async Task<Class> GetClass(int classId)
        {
            return await appDbContext.Classes
                .FirstOrDefaultAsync(s => s.Id == classId);
        }
        public async Task<Class> AddClass(Class _class)
        {
            try
            {
                appDbContext.Classes.Add(_class);
                await appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return _class;
        }

        public async Task<Class> UpdateClass(Class _class)
        {
            try
            {
                var _classExist = appDbContext.Classes.FirstOrDefault(p => p.Id == _class.Id);
                if (_classExist != null)
                {
                    appDbContext.Update(_class);
                    await appDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return _class;
        }

        public async Task<Class> DeleteClass(int classId)
        {
            var result = await appDbContext.Classes
                .FirstOrDefaultAsync(s => s.Id == classId);
            if (result != null)
            {
                appDbContext.Classes.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Class>> Search(string name)
        {
            IQueryable<Class> query = appDbContext.Classes;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(s => s.Name.Contains(name));
            }

            return await query.ToListAsync();
        }
        #endregion
    }
}
