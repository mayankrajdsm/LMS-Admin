using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;

namespace LMS.Mapper.Services
{
    public class UserProfileService : IUserProfileService
    {

        private readonly IUserProfileRepository _userProfileRepository;
        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public IEnumerable<UserProfile> GetAllUserProfile()
        {
            return _userProfileRepository.GetAllUsers().Result;
        }
        public int InsertUserProfile(UserProfile userProfile)
        {
            return _userProfileRepository.InsertUser(userProfile).Result;
        }
    }
}
