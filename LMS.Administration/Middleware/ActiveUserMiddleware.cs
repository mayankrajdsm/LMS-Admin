using System.Security.Claims;

namespace LMS.Administration.Middleware
{
    public class ActiveUserMiddleware
    {
        private readonly RequestDelegate _next;

        public ActiveUserMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, IActiveUserService currentUserService)
        {
            if (context.User.Identity is ClaimsIdentity identity)
            {
                var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
                currentUserService.SetUserId(userId);
            }
            else
            {
            }
            await _next(context);
        }
    }
}
