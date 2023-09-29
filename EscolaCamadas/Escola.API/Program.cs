using Escola.Dados;
using Escola.Dados.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AlunoRepository>();

var connectionString = "Server=localhost;Database=escola_db;User=root;Password=root";
var version = new MySqlServerVersion(new Version(8, 0, 21));

builder.Services.AddDbContextPool<DataContext>(
    options => options.UseMySql(connectionString, version)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors() 
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
