using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface ISocialCateogoryRepository
    {
        Task<IEnumerable<SocialCategory>> GetSocialCateogories();
        Task<SocialCategory> GetSocialCateogoryById(Guid socialCateogoryId);
        Task<int> InsertSocialCateogory(SocialCategory socialCateogory);
        Task<int> UpdateSocialCateogory(SocialCategory socialCateogory);
        Task<int> DeleteSocialCateogory(Guid socialCateogoryId);
    }
}
