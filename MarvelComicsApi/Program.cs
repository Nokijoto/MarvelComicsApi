using MarvelComicsApi.DbConn;
using MarvelComicsApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAdditionalServices();
builder.Services.AddDatabaseConnection(builder.Configuration);

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    try
    {
        if (dbContext.Database.CanConnect())
        {
            Console.WriteLine("✅ Połączenie z bazą danych SQLite zostało nawiązane.");
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


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();