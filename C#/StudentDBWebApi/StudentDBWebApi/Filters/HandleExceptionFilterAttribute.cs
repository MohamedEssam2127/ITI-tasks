using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace StudentDBWebApi.Filters
{
    public class HandleExceptionFilterAttribute:  Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            ContentResult res = new ContentResult();
            res.Content = $"Error: {context.Exception.Message} Something went wrong [form Filter ]";
            res.ContentType = "text/plain";
            res.StatusCode = 500;
            context.Result = res;
        }
    }
}
