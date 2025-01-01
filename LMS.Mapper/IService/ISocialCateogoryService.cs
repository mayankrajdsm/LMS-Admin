using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface ISocialCateogoryService
    {
        Task<List<SocialCategory>> GetSocialCateogories();
        Task<SocialCategory> GetSocialCateogoryById(string id);
        Task<int> InsertSocialCateogory(SocialCategory socialCateogory);
        Task<int> UpdateSocialCateogory(SocialCategory socialCateogory);
        Task<int> DeleteSocialCateogory(string id);
    }
}
