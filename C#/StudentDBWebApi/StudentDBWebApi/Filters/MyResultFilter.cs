using Microsoft.AspNetCore.Mvc.Filters;

namespace StudentDBWebApi.Filters
{
    public class MyResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
           
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("Hello", "World");
        }
    }
}
