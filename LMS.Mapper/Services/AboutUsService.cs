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
    public class AboutUsService: IAboutUsService
    {
        private readonly IAboutUsRepository _aboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            _aboutUsRepository = aboutUsRepository;
        }
        public async Task<List<AboutU>> GetBuildings()
        {
            List<AboutU> lstAboutUs = new List<AboutU>();
            var existingAboutUs = await _aboutUsRepository.GetAboutUs();
            foreach (var about in existingAboutUs)
            {
                lstAboutUs.Add(about.ToBusinessObject());
            }
            return lstAboutUs;
        }
        public async Task<AboutU> GetAboutUsById(string aboutId)
        {
            var about = await _aboutUsRepository.GetAboutUsById(Guid.Parse(aboutId));
            return about.ToBusinessObject();
        }
        public async Task<int> InsertAboutUs(AboutU about)
        {
            return await _aboutUsRepository.InsertAboutUs(about.ToEntityModel());
        }
        public async Task<int> UpdateAboutUs(AboutU about)
        {
            return await _aboutUsRepository.UpdateAboutUs(about.ToEntityModel());
        }
    }
}
