using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PatrolPal;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


string dbConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

// Check if the connection string is null or empty
/*if (string.IsNullOrEmpty(dbConnectionString))
{
    Console.WriteLine("DB_CONNECTION_STRING environment variable is not set.");
    // You may choose to handle this case accordingly
    return;
}*/

// Use the connection string in your application
Console.WriteLine("Database connection string: " + dbConnectionString);

builder.Services.AddDbContext<EntityContext>(options => options.UseSqlServer("Server=PEACE\\SQLEXPRESS; Database=patrol_pal; Integrated Security=true; MultipleActiveResultSets=true; TrustServerCertificate=True;"));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
