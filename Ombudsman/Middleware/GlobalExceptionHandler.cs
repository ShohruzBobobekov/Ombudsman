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
            // Handle the exception and generate a custom response
            await HandleExceptionAsync(context, ex);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        // Perform any custom exception handling logic here
        // You can log the exception, generate a custom error response, etc.

        // Set the response status code
        context.Response.StatusCode=500;

        // Write the error message to the response
        await context.Response.WriteAsync("An error occurred. Please try again later.");
    }
}
