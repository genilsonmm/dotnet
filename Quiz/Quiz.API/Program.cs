using Microsoft.EntityFrameworkCore;
using Quiz.DATA.Data;
using Quiz.DATA.Repository;
using Quiz.DATA.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<RespostaRepository>();
builder.Services.AddScoped<QuestaoRepository>();

builder.Services.AddScoped<QuestaoService>();

/*
builder.Services.AddControllers()
            .AddJsonOptions(o => o.JsonSerializerOptions
                .ReferenceHandler = ReferenceHandler.Preserve);
*/

var connectionString = "Server=localhost;Database=quizDb;User=root;Password=root";
var version = new MySqlServerVersion(new Version(8, 0, 21));

builder.Services.AddDbContextPool<DataContext>(
    options => options.UseMySql(connectionString, version)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors());


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
