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
    public class ClassesListBase : ComponentBase
    {
        [Inject]
        public IClassService ClassService { get; set; }
        public IEnumerable<Class> Classes { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Classes = (await ClassService.GetClasses()).ToList();
        }
    }
}
