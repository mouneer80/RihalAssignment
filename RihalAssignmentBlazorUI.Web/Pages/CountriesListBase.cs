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
    public class CountriesListBase : ComponentBase
    {
        [Inject]
        public ICountryService CountryService { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Countries = (await CountryService.GetCountries()).ToList();
        }
    }
}
