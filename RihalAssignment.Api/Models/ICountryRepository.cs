using RihalAssignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> Search(string name);
        Task<IEnumerable<Country>> GetCountries();
        Task<Country> GetCountry(int countryId);
        Task<Country> AddCountry(Country country);
        Task<Country> UpdateCountry(Country country);
        Task<Country> DeleteCountry(int countryId);
    }
}