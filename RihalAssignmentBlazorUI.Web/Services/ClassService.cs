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
    public class ClassService : IClassService
    {
        private readonly HttpClient httpClient;

        public ClassService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Class> AddClass(Class _class)
        {
            var response = await httpClient.PostAsJsonAsync<Class>("api/classes", _class);
            return await response.Content.ReadFromJsonAsync<Class>();
        }

        public async Task<Class> GetClass(int classId)
        {
            return await httpClient.GetFromJsonAsync<Class>($"api/classes/{classId}");
        }

        public async Task<IEnumerable<Class>> GetClasses()
        {
            return await httpClient.GetFromJsonAsync<Class[]>("api/classes");
        }

        public async Task<Class> UpdateClass(int classId, Class _class)
        {
            var response = await httpClient.PutAsJsonAsync<Class>($"api/classes/updateclass/{classId}", _class);
            return await response.Content.ReadFromJsonAsync<Class>();
        }
    }
}
