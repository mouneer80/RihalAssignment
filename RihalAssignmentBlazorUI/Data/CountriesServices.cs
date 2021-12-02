using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Data
{
    public class CountriesServices
    {
        #region Private members
        private CountryDbContext dbContext;
        #endregion

        #region Constructor
        public CountriesServices(CountryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of Countries
        /// </summary>
        /// <returns></returns>
        public async Task<List<Country>> GetCountryAsync()
        {
            return await dbContext.Country.ToListAsync();
        }

        /// <summary>
        /// This method add a new Country to the DbContext and saves it
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public async Task<Country> AddCountryAsync(Country Country)
        {
            try
            {
                dbContext.Country.Add(Country);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Country;
        }

        /// <summary>
        /// This method update and existing Country and saves the changes
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public async Task<Country> UpdateCountryAsync(Country Country)
        {
            try
            {
                var countryExist = dbContext.Country.FirstOrDefault(p => p.Id == Country.Id);
                if (countryExist != null)
                {
                    dbContext.Update(Country);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Country;
        }

        /// <summary>
        /// This method removes and existing Country from the DbContext and saves it
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public async Task DeleteCountryAsync(Country Country)
        {
            try
            {
                dbContext.Country.Remove(Country);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
