using Microsoft.EntityFrameworkCore;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
{
    public class StudentRepository : IStudentRepository
    {
        #region Private members
        private readonly AppDbContext appDbContext;
        #endregion

        #region Constructor
        public StudentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        #endregion

        #region Public methods
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await appDbContext.Students
                .Include(e => e.Countries)
                .Include(e => e.Classes)
                .ToListAsync();
        }
        public async Task<Student> GetStudent(int studentId)
        {
            return await appDbContext.Students
                .Include(e => e.Countries)
                .Include(e => e.Classes)
                .FirstOrDefaultAsync(s => s.Id == studentId);
        }
        public async Task<Student> AddStudent(Student Student)
        {
            try
            {
                appDbContext.Students.Add(Student);
                await appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Student;
        }
        public async Task<Student> UpdateStudent(Student Student)
        {
            try
            {
                var studentExist = appDbContext.Students.FirstOrDefault(p => p.Id == Student.Id);
                if (studentExist != null)
                {
                    appDbContext.Update(Student);
                    await appDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Student;
        }
        public async Task<Student> DeleteStudent(int studentId)
        {
            var result = await appDbContext.Students
                .FirstOrDefaultAsync(s => s.Id == studentId);
            if (result != null)
            {
                appDbContext.Students.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Student>> Search(string name)
        {
            IQueryable<Student> query = appDbContext.Students;

            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(s => s.Name.Contains(name));
            }

            return await query.ToListAsync();
        }
        #endregion
    }
}