using RihalAssignment.Models;
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

        public async Task DeleteStudent(int studentId)
        {
            await httpClient.DeleteAsync($"api/students/{studentId}");
        }

        public async Task<Student> GetStudent(int studentId)
        {
            return await httpClient.GetFromJsonAsync<Student>($"api/students/{studentId}");
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await httpClient.GetFromJsonAsync<Student[]>("api/students");
        }

        public async Task<Student> AddStudent(Student student)
        {
            var response = await httpClient.PostAsJsonAsync<Student>("api/students", student);
            return await response.Content.ReadFromJsonAsync<Student>();
        }

        public async Task<Student> UpdateStudent(int studentId, Student student)
        {
            var response = await httpClient.PutAsJsonAsync<Student>($"api/students/{studentId}", student);
            return await response.Content.ReadFromJsonAsync<Student>();
        }
    }
}
