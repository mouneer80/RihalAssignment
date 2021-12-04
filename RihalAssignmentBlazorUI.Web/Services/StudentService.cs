﻿using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Web.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;

        public StudentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await httpClient.GetFromJsonAsync<Student[]>("api/students");
        }
    }
}
