using Bogus;
using RihalAssignment.Api.Models;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalAssignment.TestProject
{
    class StudentServiceFake : IStudentRepository
    {
        private readonly List<Student> _students;
        private readonly List<Class> _classes;
        private readonly List<Country> _countries;


        public StudentServiceFake()
        {
            const int numToSeed = 100;

            var gId = 1;
            _classes = new List<Class>()
            {
                new Class(){ Id = gId++, Name = "Class 7" },
                new Class(){ Id = gId++, Name = "Class 8" },
                new Class(){ Id = gId++, Name = "Class 9" },
                new Class(){ Id = gId++, Name = "Class 10" },
                new Class(){ Id = gId++, Name = "Class 11" },
                new Class(){ Id = gId++, Name = "Class 12" }
            };

            var cId = 1;
            _countries = new List<Country>()
            {
                new Country() { Id = cId++, Name = "Oman" },
                new Country() { Id = cId++, Name = "Egypt" },
                new Country() { Id = cId++, Name = "India" },
                new Country() { Id = cId++, Name = "Pakistan" }
            };

            var sId = 1;
            var startDate = DateTime.ParseExact("20010101", "yyyyMMdd", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact("20091231", "yyyyMMdd", CultureInfo.InvariantCulture);
            Faker<Student> studentFaker = new Faker<Student>()
                .StrictMode(false)
                .UseSeed(1122)
                .RuleFor(s => s.Id, f => sId++)
                .RuleFor(s => s.Name, f => f.Name.FullName())
                .RuleFor(s => s.DateOfBirth, f => f.Date.Between(startDate, endDate))
                .RuleFor(s => s.ClassId, f => f.PickRandom(_classes).Id)
                .RuleFor(s => s.CountryId, f => f.PickRandom(_countries).Id)
                ;

            _students = studentFaker.Generate(numToSeed);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return _students.AsEnumerable();
        }

        public async Task<Student> AddStudent(Student newItem)
        {
            _students.Add(newItem);
            return newItem;
        }

        public async Task<Student> GetStudent(int id)
        {
            return _students.Where(a => a.Id == id)
                .FirstOrDefault();
        }

        public async Task DeleteStudent(int id)
        {
            var existing = _students.First(a => a.Id == id);
            _students.Remove(existing);
        }

        public Task<IEnumerable<Student>> Search(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudent(Student Student)
        {
            throw new NotImplementedException();
        }
    }
}
