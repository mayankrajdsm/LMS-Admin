using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.BusinessObject;

namespace LMS.Mapper.Services
{
    public class SocialCateogoryService : ISocialCateogoryService
    {
        private readonly ISocialCateogoryRepository _socialCateogoryRepository;

        public SocialCateogoryService(ISocialCateogoryRepository socialCateogoryRepository) => _socialCateogoryRepository = socialCateogoryRepository;

        public async Task<List<SocialCateogory>> GetSocialCateogories()
        {
            List<SocialCateogory> socialCateogories = new List<SocialCateogory>();
            var existingSocialCateogories = await _socialCateogoryRepository.GetSocialCateogories();
            if (existingSocialCateogories != null)
            {
                foreach (var socialCateogory in existingSocialCateogories)
                {
                    socialCateogories.Add(socialCateogory.ToBusinessObject());
                }
            }
            return socialCateogories;
        }
        public async Task<SocialCateogory> GetSocialCateogoryById(string id)
        {
            var socialCateogory = await _socialCateogoryRepository.GetSocialCateogoryById(Guid.Parse(id));
            return socialCateogory.ToBusinessObject();
        }
        public async Task<int> InsertSocialCateogory(SocialCateogory socialCateogory) => await _socialCateogoryRepository.InsertSocialCateogory(socialCateogory.ToEntityModel());
        public async Task<int> UpdateSocialCateogory(SocialCateogory socialCateogory) => await _socialCateogoryRepository.UpdateSocialCateogory(socialCateogory.ToEntityModel());
        public async Task<int> DeleteSocialCateogory(string id) => await _socialCateogoryRepository.DeleteSocialCateogory(Guid.Parse(id));
    }
}
