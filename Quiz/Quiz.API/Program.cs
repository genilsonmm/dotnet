using Microsoft.EntityFrameworkCore;
using Quiz.DATA.Data;
using Quiz.DATA.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = "Server=localhost;Database=QuestaoBD;User=root;Password=root";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));

builder.Services.AddDbContextPool<DataContext>(
    options => options.UseMySql(connectionString, serverVersion)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors());

builder.Services.AddScoped<QuestaoService>();
builder.Services.AddScoped<RespostasService>();

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
