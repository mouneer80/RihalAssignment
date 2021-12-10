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
    public class CountriesController : ControllerBase
    {
        private readonly ICountryRepository countryRepository;

        public CountriesController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Country>>> SearchCountries(string name)
        {
            try
            {
                var result = await countryRepository.Search(name);

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
        public async Task<ActionResult> GetCountries()
        {
            try
            {
                return Ok(await countryRepository.GetCountries());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
            try
            {
                var result = await countryRepository.GetCountry(id);
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
        public async Task<ActionResult<Country>> CreateCountry(Country country)
        {
            try
            {
                if (country == null)
                {
                    return BadRequest();
                }
                var createdCountry = await countryRepository.AddCountry(country);

                return CreatedAtAction(nameof(GetCountry), new { id = createdCountry.Id }, createdCountry);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPut("updatecountry/{id:int}")]
        public async Task<ActionResult<Country>> UpdateCountry(int id, Country country)
        {
            try
            {
                if (id != country.Id)
                {
                    return BadRequest("Country ID mismatch");
                }
                var countryToUpdate = await countryRepository.GetCountry(id);

                if (countryToUpdate == null)
                {
                    return NotFound($"Country with Id = {id} not found");
                }

                return await countryRepository.UpdateCountry(country);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        [HttpDelete("deletecountry/{id:int}")]
        public async Task<ActionResult<Country>> DeleteCountry(int id)
        {
            try
            {
                var countryToDelete = await countryRepository.GetCountry(id);

                if (countryToDelete == null)
                {
                    return NotFound($"Country with Id = {id} not found");
                }

                return await countryRepository.DeleteCountry(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}
