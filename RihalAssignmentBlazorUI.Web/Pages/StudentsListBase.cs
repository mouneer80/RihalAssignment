using Microsoft.AspNetCore.Components;
using RihalAssignment.Models;
using RihalAssignmentBlazorUI.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Web.Pages
{
    public class StudentsListBase : ComponentBase
    {
        [Inject]
        public IStudentService _studentService { get; set; }
        public IEnumerable<Student> Students { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Students = (await _studentService.GetStudents()).ToList();
        }
    }
}
