using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class GenderRepository
    {
        private readonly TestContext _context;
        public GenderRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<Gender>> GetGenders() => _context.Genders.ToList();
        public async Task<Gender> GetGenderById(Guid genderId) => await _context.Genders.FindAsync(genderId);
        public async Task<int> InsertGender(Gender gender)
        {
            _context.Genders.Add(gender);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateGender(Gender gender) => await _context.SaveChangesAsync();
        public async Task<int> DeleteGender(Guid genderId)
        {
            var gender = await _context.Genders.FindAsync(genderId);
            _context.Genders.Remove(gender);
            return await _context.SaveChangesAsync();
        }
    }
}
