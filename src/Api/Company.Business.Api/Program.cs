using Company.Business.Persistence.Database;
using Empresa.Negocio.Application.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseService>(options=>
options.UseSqlServer(builder.Configuration["SQLConnectionString"]) );

builder.Services.AddScoped<IDatabaseService, DatabaseService>();

var app = builder.Build();
app.Run();