using LMS.Infrastructures.Interface;
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
    public class SocialCateogoryService : ISocialCateogoryService
    {
        private readonly ISocialCateogoryRepository _socialCateogoryRepository;

        public SocialCateogoryService(ISocialCateogoryRepository socialCateogoryRepository) => _socialCateogoryRepository = socialCateogoryRepository;

        public async Task<List<SocialCategory>> GetSocialCateogories()
        {
            List<SocialCategory> socialCateogories = new List<SocialCategory>();
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
        public async Task<SocialCategory> GetSocialCateogoryById(string id)
        {
            var socialCateogory = await _socialCateogoryRepository.GetSocialCateogoryById(Guid.Parse(id));
            return socialCateogory.ToBusinessObject();
        }
        public async Task<int> InsertSocialCateogory(SocialCategory socialCateogory) => await _socialCateogoryRepository.InsertSocialCateogory(socialCateogory.ToEntityModel());
        public async Task<int> UpdateSocialCateogory(SocialCategory socialCateogory) => await _socialCateogoryRepository.UpdateSocialCateogory(socialCateogory.ToEntityModel());
        public async Task<int> DeleteSocialCateogory(string id) => await _socialCateogoryRepository.DeleteSocialCateogory(Guid.Parse(id));
    }
}
