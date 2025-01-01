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
    public class CityRepository: ICityRepository
    {
        private readonly FunskoolsContext _context;
        public CityRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<City>> GetCities() => await _context.Cities.ToListAsync();
        public async Task<City> GetCityById(Guid id) => await _context.Cities.FindAsync(id);
        public async Task<int> InsertBatch(City  city)
        {
            _context.Cities.Add(city);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateCity(City city)
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteBatch(Guid id)
        {
            var city = await _context.Cities.FindAsync(id);
            _context.Cities.Remove(city);
            return await _context.SaveChangesAsync();
        }
    }
}