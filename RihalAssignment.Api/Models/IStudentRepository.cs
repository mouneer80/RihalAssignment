using RihalAssignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> Search(string name);
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudent(int studentId);
        Task<Student> AddStudent(Student Student);
        Task<Student> UpdateStudent(Student Student);
        Task<Student> DeleteStudent(int studentId);
    }
}