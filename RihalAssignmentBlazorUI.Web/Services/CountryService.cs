using RihalAssignment.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Web.Services
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient httpClient;

        public CountryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await httpClient.GetFromJsonAsync<Country[]>("api/countries");
        }

        public async Task<Country> GetCountry(int countryId)
        {
            return await httpClient.GetFromJsonAsync<Country>($"api/countries/{countryId}");
        }
    }
}
