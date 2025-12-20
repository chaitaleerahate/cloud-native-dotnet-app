var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Read config from environment variable
var message = Environment.GetEnvironmentVariable("MESSAGE")              //Message comes from outsid ethe code Later -> docker enc -> kubernetes configMap // Same IMAGE DIFFERENT BEHAVIOR
              ?? "Hello from .NET API (default message)";                // Reads config from environment, Later - Kubernetes Config Map. If env var not set app still works (default value)

app.MapGet("/", () =>                          //Root endpoint
{
    return Results.Ok(new
    {
        status = "Running",
        message = message
    });
});

app.Run();

//Code stays same, config changes