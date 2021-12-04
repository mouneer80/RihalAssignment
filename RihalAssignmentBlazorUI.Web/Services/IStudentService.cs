using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Web.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudents();
    }
}
