using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Web.Services
{
    public interface IClassService
    {
        Task<IEnumerable<Class>> GetClasses();
        Task<Class> GetClass(int classId);
        Task<Class> AddClass(Class _class);
        Task<Class> UpdateClass(int classId, Class _class);
    }
}
