using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IContactUsService
    {
        Task<List<ContactU>> GetContactUs();
        Task<ContactU> GetContactUsById(string contactId);
        Task<int> InsertContactUs(ContactU contact);
        Task<int> UpdateContactUs(ContactU contact);
    }
}
