namespace Ombudsman.Api.Middleware;

public class GlobalExceptionHandler : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch(Exception ex)
        {
            await HandleExceptionAsync(context, ex.Message);
        }
    }
    private static async Task HandleExceptionAsync(HttpContext context, string message)
    {
        context.Response.ContentType = "application/json";
        context.Response.Clear();
        await context.Response.WriteAsync(message);
        
    }
}
