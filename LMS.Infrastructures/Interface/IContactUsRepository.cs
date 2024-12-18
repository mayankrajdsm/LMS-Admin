using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IContactUsRepository
    {
        Task<IEnumerable<ContactU>> GetContactUs();
        Task<ContactU> GetContactUsById(Guid contactId);
        Task<int> InsertContactUs(ContactU contact);
        Task<int> UpdateContactUs(ContactU contact);
    }
}
