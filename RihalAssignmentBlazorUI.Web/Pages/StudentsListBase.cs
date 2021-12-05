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
        [Inject]
        public IClassService _classService { get; set; }
        [Inject]
        public ICountryService _countryService { get; set; }
        public List<Student> Students { get; set; }
        public List<Class> Classes { get; set; }
        public List<Country> Countries { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Students = (await _studentService.GetStudents()).ToList();

            Classes = (await _classService.GetClasses()).ToList();
            Countries = (await _countryService.GetCountries()).ToList();

        }
    }
}
