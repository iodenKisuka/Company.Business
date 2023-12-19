using Company.Business.Persistence.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseService>(options=>
options.UseSqlServer(builder.Configuration["SQLConnectionString"]) );

var app = builder.Build();
app.Run();