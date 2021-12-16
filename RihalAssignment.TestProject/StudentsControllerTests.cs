using Microsoft.AspNetCore.Mvc;
using Moq;
using RihalAssignment.Api.Controllers;
using RihalAssignment.Api.Models;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RihalAssignment.TestProject
{
    public class StudentsControllerTests
    {
        private readonly StudentsController _controller;
        private readonly IStudentRepository _service;

        public StudentsControllerTests()
        {
            _service = new StudentServiceFake();
            _controller = new StudentsController(_service);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetStudents();

            // Assert
            Assert.IsType<OkObjectResult>(await okResult as OkObjectResult);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsAllStudents()
        {
            // Act
            var okResult = await _controller.GetStudents() as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Student>>(okResult.Value as List<Student>);
            Assert.Equal(100, items.Count);
        }

        [Fact]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _controller.GetStudent(102).Result;

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetById_ExistingIdPassed_ReturnsOkResult()
        {
            // Arrange
            var testId = 105;

            // Act
            var okResult = _controller.GetStudent(testId).Result;

            // Assert
            Assert.IsType<Student>(okResult.Value);
        }

        [Fact]
        public async void GetById_ExistingIdPassed_ReturnsRightItem()
        {
            // Arrange
            var testId = 2;

            // Act
            var student = await _controller.GetStudent(testId);

            // Assert
            Assert.IsType<Student>(student.Value);
            Assert.Equal(testId, (student.Value as Student).Id);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Student testItem = new Student()
            {
                Name = "Guinness",
                DateOfBirth = new DateTime(2014, 1, 2),
                ClassId = 2,
                CountryId = 1
            };

            // Act
            var createdResponse = _controller.CreateStudent(testItem).Result.Result;

            // Assert
            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }

        [Fact]
        public void Remove_ExistingIdPassed_ReturnsNoContentResult()
        {
            // Arrange
            var existingId = 101;

            // Act
            var noContentResponse = _controller.DeleteStudent(existingId).Result;

            // Assert
            Assert.IsType<NotFoundObjectResult>(noContentResponse);
        }

        [Fact]
        public void Remove_ExistingIdPassed_RemovesOneItem()
        {
            // Arrange
            var existingId = 6;
            var studentCountBeforeRemove = _service.GetStudents().Result.Count();
            // Act
            var okResponse = _controller.DeleteStudent(existingId);

            // Assert
            Assert.Equal(studentCountBeforeRemove-1, _service.GetStudents().Result.Count());
        }
    }
}
