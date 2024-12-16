using Microsoft.AspNetCore.Mvc.Filters;

namespace LMS.Administration.Filters
{
    public class CustomAuthFilter : IPageFilter
    {
        public void OnPageHandlerSelected(PageHandlerSelectedContext context) { }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            var isAuthenticated = context.HttpContext.User.Identity?.IsAuthenticated ?? false;

            if (!isAuthenticated)
            {
                context.HttpContext.Response.Redirect("/Account/Login");
                //context.Cancel = true; // Cancel the execution of the handler
            }
        }
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context) { }
    }
}
