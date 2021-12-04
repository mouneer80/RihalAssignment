using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RihalAssignment.Api.Models;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IClassRepository classRepository;

        public ClassesController(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Class>>> SearchClasses(string name)
        {
            try
            {
                var result = await classRepository.Search(name);

                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetClasses()
        {
            try
            {
                return Ok(await classRepository.GetClasses());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Class>> GetClass(int id)
        {
            try
            {
                var result = await classRepository.GetClass(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Class>> CreateClass(Class _class)
        {
            try
            {
                if (_class == null)
                {
                    return BadRequest();
                }
                var createdClass = await classRepository.AddClass(_class);

                return CreatedAtAction(nameof(GetClass), new { id = createdClass.Id }, createdClass);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPut("id:int")]
        public async Task<ActionResult<Class>> UpdateClass(int id, Class _class)
        {
            try
            {
                if (id != _class.Id)
                {
                    return BadRequest("Class ID mismatch");
                }
                var classToUpdate = await classRepository.GetClass(id);

                if (classToUpdate == null)
                {
                    return NotFound($"Class with Id = {id} not found");
                }

                return await classRepository.UpdateClass(_class);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        [HttpDelete("id:int")]
        public async Task<ActionResult<Class>> DeleteClass(int id)
        {
            try
            {

                var classToDelete = await classRepository.GetClass(id);

                if (classToDelete == null)
                {
                    return NotFound($"Class with Id = {id} not found");
                }

                return await classRepository.DeleteClass(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}
