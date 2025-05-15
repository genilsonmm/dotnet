using AppBooks.DATA;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration.GetValue<string>("MySqlConnection:MySqlConnectionString");
builder.Services.AddDbContextPool<DataContext>(
    options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 21)))
    .EnableDetailedErrors()
    .EnableDetailedErrors()
);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
