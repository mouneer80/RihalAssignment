using RihalAssignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
{
    public interface IClassRepository
    {
        Task<IEnumerable<Class>> Search(string name);
        Task<IEnumerable<Class>> GetClasses();
        Task<Class> GetClass(int classId);
        Task<Class> AddClass(Class _class);
        Task<Class> UpdateClass(Class _class);
        Task<Class> DeleteClass(int classId);
    }
}