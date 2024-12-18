using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class ContactUsService: IContactUsService
    {
        private readonly IContactUsRepository _contactUsRepository;
        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }
        public async Task<List<ContactU>> GetContactUs()
        {
            List<ContactU> lstContactUs = new List<ContactU>();
            var existingContactUs = await _contactUsRepository.GetContactUs();
            if (existingContactUs != null)
            {
                foreach (var contact in existingContactUs)
                {
                    lstContactUs.Add(contact.ToBusinessObject());
                }
            }
            return lstContactUs;
        }
        public async Task<ContactU> GetContactUsById(string contactId)
        {
            var about = await _contactUsRepository.GetContactUsById(Guid.Parse(contactId));
            return about.ToBusinessObject();
        }
        public async Task<int> InsertContactUs(ContactU contact)
        {
            return await _contactUsRepository.InsertContactUs(contact.ToEntityModel());
        }
        public async Task<int> UpdateContactUs(ContactU contact)
        {
            return await _contactUsRepository.UpdateContactUs(contact.ToEntityModel());
        }
    }
}
