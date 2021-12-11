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
            var items = Assert.IsType<List<Student>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _controller.GetStudent(1);

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult);
        }

        [Fact]
        public async void GetById_ExistingIdPassed_ReturnsOkResult()
        {
            // Arrange
            var testId = 5;

            // Act
            var okResult = await _controller.GetStudent(testId);

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result as OkObjectResult);
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
        public void Add_InvalidObjectPassed_ReturnsBadRequest()
        {
            // Arrange
            var nameMissingItem = new Student()
            {
                Name = "Gu",
                DateOfBirth = DateTime.Now
            };
            _controller.ModelState.AddModelError("Name", "Required");

            // Act
            var badResponse = _controller.CreateStudent(nameMissingItem);

            // Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Student testItem = new Student()
            {
                Name = "Guinness",
                DateOfBirth = new DateTime(2014,1,2),
                ClassId = 2,
                CountryId = 1
            };

            // Act
            var createdResponse = _controller.CreateStudent(testItem);

            // Assert
            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            var testItem = new Student()
            {
                Name = "Guinness",
                DateOfBirth = new DateTime(2014, 1, 2),
                ClassId = 2,
                CountryId = 1
            };

            // Act
            var createdResponse = _controller.CreateStudent(testItem); 
            var item = createdResponse.Result;

            // Assert
            Assert.IsType<Student>(item);
            Assert.Equal("Guinness", item.Value.Name);
        }

        [Fact]
        public void Remove_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            // Arrange
            var notExistingId = 6;

            // Act
            var badResponse = _controller.DeleteStudent(notExistingId);

            // Assert
            Assert.IsType<NotFoundResult>(badResponse);
        }

        [Fact]
        public void Remove_ExistingIdPassed_ReturnsNoContentResult()
        {
            // Arrange
            var existingId = 6;

            // Act
            var noContentResponse = _controller.DeleteStudent(existingId);

            // Assert
            Assert.IsType<NoContentResult>(noContentResponse);
        }

        [Fact]
        public void Remove_ExistingIdPassed_RemovesOneItem()
        {
            // Arrange
            var existingId = 1;

            // Act
            var okResponse = _controller.DeleteStudent(existingId);

            // Assert
            Assert.Equal(2, _service.GetStudents().Result.Count());
        }
    }
}
