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
        Task<IEnumerable<SocialCateogory>> GetSocialCateogories();
        Task<SocialCateogory> GetSocialCateogoryById(Guid socialCateogoryId);
        Task<int> InsertSocialCateogory(SocialCateogory socialCateogory);
        Task<int> UpdateSocialCateogory(SocialCateogory socialCateogory);
        Task<int> DeleteSocialCateogory(Guid socialCateogoryId);
    }
}
