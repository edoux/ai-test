var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.WebHost.UseSentry(options =>
{
    options.Dsn = builder.Configuration["Sentry:Dsn"];
    options.Debug = true; // Enable debug mode (optional, for local testing)
    options.TracesSampleRate = 1.0; // Capture 100% of transactions for performance monitoring (adjust in prod)
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();