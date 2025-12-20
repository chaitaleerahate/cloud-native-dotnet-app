var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async () =>
{
    using var client = new HttpClient();

    // Call GreetingService using Kubernetes Service name
    var greeting = await client.GetStringAsync("http://greeting-service/Greeting");

    return $"CloudNativeApp received → {greeting}";
});

app.Run();
