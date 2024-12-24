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
        Task<List<SocialCateogory>> GetSocialCateogories();
        Task<SocialCateogory> GetSocialCateogoryById(string id);
        Task<int> InsertSocialCateogory(SocialCateogory socialCateogory);
        Task<int> UpdateSocialCateogory(SocialCateogory socialCateogory);
        Task<int> DeleteSocialCateogory(string id);
    }
}
