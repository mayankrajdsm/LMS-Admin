using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class UserProfileController : Controller
    {

        private readonly IUserProfileService _userProfile; 
        public UserProfileController(IUserProfileService userProfile)
        {
            _userProfile = userProfile;
        }
        public IActionResult Index()
        {
            IEnumerable<UserProfile> _userList = new List<UserProfile>();
            _userList = _userProfile.GetAllUserProfile();
            return View(_userList);
        }

        [HttpPost]
        public IActionResult SaveUser(UserProfile userProfile)
        {
            try
            {
                userProfile.Id = Guid.NewGuid();
                userProfile.LastLogin = DateTime.Now;
                int SaveData = _userProfile.InsertUserProfile(userProfile);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
