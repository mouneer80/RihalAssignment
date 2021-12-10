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
        public async Task<Student> AddStudent(Student student)
        {
            if (student.Countries != null)
            {
                appDbContext.Entry(student.Countries).State = EntityState.Unchanged;
            }
            if (student.Classes != null)
            {
                appDbContext.Entry(student.Classes).State = EntityState.Unchanged;
            }
            student.ModifiedDate = DateTime.Now;
            student.CreatedDate = DateTime.Now;
            var result = await appDbContext.Students.AddAsync(student);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Student> UpdateStudent(Student student)
        {
            var studentExist = appDbContext.Students
                .FirstOrDefault(p => p.Id == student.Id);

            if (studentExist != null)
            {
                studentExist.Name = student.Name;
                studentExist.DateOfBirth = student.DateOfBirth;
                if (student.ClassId != 0)
                {
                    studentExist.ClassId = student.ClassId;
                }
                else if(student.Classes != null)
                {
                    studentExist.ClassId = student.Classes.Id;
                }
                if (student.CountryId != 0)
                {
                    studentExist.CountryId = student.CountryId;
                }
                else if (student.Countries != null)
                {
                    studentExist.CountryId = student.Countries.Id;
                }
                studentExist.ModifiedDate = DateTime.Now;

                await appDbContext.SaveChangesAsync();

                return studentExist;
            }
            return null;
        }
        public async Task DeleteStudent(int studentId)
        {
            var result = await appDbContext.Students
                .FirstOrDefaultAsync(s => s.Id == studentId);
            if (result != null)
            {
                appDbContext.Students.Remove(result);
                await appDbContext.SaveChangesAsync();
                //return result;
            }
            //return null;
        }

        public async Task<IEnumerable<Student>> Search(string name)
        {
            IQueryable<Student> query = appDbContext.Students;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(s => s.Name.Contains(name));
            }

            return await query.ToListAsync();
        }
        #endregion
    }
}