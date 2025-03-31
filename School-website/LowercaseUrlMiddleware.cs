public class LowercaseUrlMiddleware
{
    private readonly RequestDelegate _next;

    public LowercaseUrlMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var requestPath = context.Request.Path.Value;

        // Check if the path is not null and contains uppercase letters
        if (!string.IsNullOrEmpty(requestPath) && requestPath != requestPath.ToLowerInvariant())
        {
            // Redirect to the lowercase version
            context.Response.Redirect(requestPath.ToLowerInvariant(), true);
            return;
        }

        // Proceed with the rest of the pipeline
        await _next(context);
    }
}
