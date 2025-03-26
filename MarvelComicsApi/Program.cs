using System.Collections;
using MarvelComicsApi.DbConn;
using MarvelComicsApi.Extensions;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/api_.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();


builder.Host.UseSerilog();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAdditionalServices();
builder.Services.AddDatabaseConnection(builder.Configuration);

var app = builder.Build();

Console.WriteLine("🔧 Konfiguracja aplikacji:");

foreach (var kv in builder.Configuration.AsEnumerable())
    if (!string.IsNullOrEmpty(kv.Value))
        Console.WriteLine($"  🔹 {kv.Key} = {kv.Value}");

Console.WriteLine("🌍 Zmienne środowiskowe (ENV):");
foreach (DictionaryEntry env in Environment.GetEnvironmentVariables())
{
    var key = env.Key?.ToString();
    var value = env.Value?.ToString();
    if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        Console.WriteLine($"  🌱 {key} = {value}");
}


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    try
    {
        if (dbContext.Database.CanConnect())
        {
            Console.WriteLine("✅ Połączenie z bazą danych zostało nawiązane.");
            if (dbContext.Database.GetPendingMigrations().Any()) dbContext.Database.Migrate();
            Console.WriteLine("✅ Baza danych została zaktualizowana.");
        }
        else
        {
            Console.WriteLine("❌ Nie można połączyć się z bazą danych.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Błąd połączenia z bazą danych: {ex.Message}");
    }
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();