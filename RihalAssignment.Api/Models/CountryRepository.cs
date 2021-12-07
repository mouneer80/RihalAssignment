using Microsoft.EntityFrameworkCore;
using RihalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Api.Models
{
    public class CountryRepository : ICountryRepository
    {
        #region Private members
        private readonly AppDbContext appDbContext;
        #endregion

        #region Constructor
        public CountryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        #endregion

        #region Public methods
        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await appDbContext.Countries.ToListAsync();
        }
        public async Task<Country> GetCountry(int countryId)
        {
            return await appDbContext.Countries
                .FirstOrDefaultAsync(s => s.Id == countryId);
        }
        public async Task<Country> AddCountry(Country country)
        {
            var result = await appDbContext.Countries.AddAsync(country);
            await appDbContext.SaveChangesAsync();

            return result.Entity;
        }
        public async Task<Country> UpdateCountry(Country country)
        {
            var countryExist = appDbContext.Countries.FirstOrDefault(p => p.Id == country.Id);
            if (countryExist != null)
            {
                countryExist.Name = country.Name;
                await appDbContext.SaveChangesAsync();
                return countryExist;
            }
            return null;
        }
        public async Task<Country> DeleteCountry(int countryId)
        {
            var result = await appDbContext.Countries
                .FirstOrDefaultAsync(s => s.Id == countryId);
            if (result != null)
            {
                appDbContext.Countries.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task<IEnumerable<Country>> Search(string name)
        {
            IQueryable<Country> query = appDbContext.Countries;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(s => s.Name.Contains(name));
            }

            return await query.ToListAsync();
        }
        #endregion
    }
}