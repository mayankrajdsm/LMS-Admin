using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly TestContext _context;
        public CountryRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<Country>> GetCountries() => await _context.Countries.ToListAsync();
        public async Task<Country> GetCountryById(Guid countryId) => await _context.Countries.FindAsync(countryId);
        public async Task<int> InsertCountry(Country country)
        {
            _context.Countries.Add(country);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateCountry(Country country) => await _context.SaveChangesAsync();
        public async Task<int> DeleteCountry(Guid countryId)
        {
            var existingCountry = await _context.Countries.FindAsync(countryId);
            _context.Countries.Remove(existingCountry);
            return await _context.SaveChangesAsync();
        }
    }
}
