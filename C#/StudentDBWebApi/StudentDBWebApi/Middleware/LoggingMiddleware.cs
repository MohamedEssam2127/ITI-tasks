using System.Diagnostics;

namespace StudentDBWebApi.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            _logger.LogInformation($"Request Path => {context.Request.Path} , " +
                $"method => {context.Request.Method}");
            await _next(context);
            stopwatch.Stop();
            _logger.LogInformation($"Response Status Code => {context.Response.StatusCode} , Time Taken => {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}