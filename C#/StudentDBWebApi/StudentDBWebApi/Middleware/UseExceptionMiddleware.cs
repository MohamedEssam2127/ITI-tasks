namespace StudentDBWebApi.Middleware
{
    public static class UseExceptionMiddleware
    {

        public static IApplicationBuilder UseException(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
