using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Data
{
    public class StudentsServices
    {
        #region Private members
        private AppDbContext dbContext;
        #endregion

        #region Constructor
        public StudentsServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of Students
        /// </summary>
        /// <returns></returns>
        public async Task<List<Student>> GetStudentAsync()
        {
            return await dbContext.Student.ToListAsync();
        }

        /// <summary>
        /// This method add a new Student to the DbContext and saves it
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task<Student> AddStudentAsync(Student Student)
        {
            try
            {
                dbContext.Student.Add(Student);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Student;
        }

        /// <summary>
        /// This method update and existing Student and saves the changes
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task<Student> UpdateStudentAsync(Student Student)
        {
            try
            {
                var studentExist = dbContext.Student.FirstOrDefault(p => p.Id == Student.Id);
                if (studentExist != null)
                {
                    dbContext.Update(Student);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Student;
        }

        /// <summary>
        /// This method removes and existing Student from the DbContext and saves it
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task DeleteStudentAsync(Student Student)
        {
            try
            {
                dbContext.Student.Remove(Student);
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
