namespace LMS.Administration.Middleware
{
    public class ActiveUserService : IActiveUserService
    {
        public string UserId { get; private set; }

        public void SetUserId(string userId)
        {
            UserId = userId;
        }
    }
}
