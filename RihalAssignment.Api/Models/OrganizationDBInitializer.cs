using Bogus;
using FizzWare.NBuilder;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
{
    public class OrganizationDBInitializer
    {
        public List<Class> Classes { get; set; }
        public List<Country> Countries { get; set; }
        public List<Student> Students { get; set; }

        public OrganizationDBInitializer()
        {
            //GeneratingDataUsingBogus();
            SeedDataUsingNBuilder();
        }

        private void GeneratingDataUsingBogus()
        {
            const int numToSeed = 100;

            var gId = 1;
            Classes = new List<Class>()
            {
                new Class(){ Id = gId++, Name = "Class 7" },
                new Class(){ Id = gId++, Name = "Class 8" },
                new Class(){ Id = gId++, Name = "Class 9" },
                new Class(){ Id = gId++, Name = "Class 10" },
                new Class(){ Id = gId++, Name = "Class 11" },
                new Class(){ Id = gId++, Name = "Class 12" }
            };

            var cId = 1;
            Countries = new List<Country>()
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
                .RuleFor(s => s.ClassId, f => f.PickRandom(Classes).Id)
                .RuleFor(s => s.CountryId, f => f.PickRandom(Countries).Id)
                ;

            Students = studentFaker.Generate(numToSeed);
        }

        protected void SeedDataUsingNBuilder()
        {
            Countries = Builder<Country>.CreateListOfSize(10)
                .All()
                .With(country => country.Name = Faker.Country.Name())
                .With(country => country.CreatedDate = new DateTime(Faker.RandomNumber.Next(2020, 2021), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
                .With(country => country.ModifiedDate = new DateTime(Faker.RandomNumber.Next(2020, 2021), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
                .Build()
                .ToList();
            Classes = Builder<Class>.CreateListOfSize(6)
                .All()
                .With(c => c.Name = "Grade " + c.Id.ToString())
                .With(c => c.CreatedDate = new DateTime(Faker.RandomNumber.Next(2020, 2021), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
                .With(c => c.ModifiedDate = new DateTime(Faker.RandomNumber.Next(2020, 2021), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
                .Build()
                .ToList();
            Students = Builder<Student>.CreateListOfSize(100)
                .All()
                .With(student => student.Name = Faker.Name.FullName())
                .With(student => student.ClassId = Pick<Class>.RandomItemFrom(Classes).Id)
                .With(student => student.CountryId = Pick<Country>.RandomItemFrom(Countries).Id)
                .With(student => student.DateOfBirth = new DateTime(Faker.RandomNumber.Next(2001, 2015), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
                .With(student => student.CreatedDate = new DateTime(Faker.RandomNumber.Next(2020, 2021), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
                .With(student => student.ModifiedDate = new DateTime(Faker.RandomNumber.Next(2020, 2021), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
                .Build()
                .ToList();
        }
    }
}
