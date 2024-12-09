namespace LMS.Administration.Middleware
{
    public interface IActiveUserService
    {
        string UserId { get; }
        void SetUserId(string userId);
    }
}
