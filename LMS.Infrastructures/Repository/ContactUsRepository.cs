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
    public class ContactUsRepository: IContactUsRepository
    {
        private readonly FunskoolsContext _context;
        public ContactUsRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<ContactU>> GetContactUs() => await _context.Contactus.ToListAsync();
        public async Task<ContactU> GetContactUsById(Guid contactId) => await _context.Contactus.FindAsync(contactId);
        public async Task<int> InsertContactUs(ContactU contact)
        {
            _context.Contactus.Add(contact);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateContactUs(ContactU contact) => await _context.SaveChangesAsync();
    }
}
