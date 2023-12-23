using Company.Business.Persistence.Database;
using Empresa.Negocio.Application.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseService>(options =>
options.UseSqlServer(builder.Configuration["SQLConnectionString"]));

builder.Services.AddScoped<IDatabaseService, DatabaseService>();

var app = builder.Build();
/*pruebas 
 */
app.MapPost("CreateTest", async (IDatabaseService _database) =>
{
    var entity = new Company.Business.Domain.Entities.User.UserEntity
    {
        FirstName = "Emiliano",
        LastName = "Lopez",
        UserName = "EmiLop",
        Password = "Alumno1234?"
    };
    await _database.User.AddAsync(entity);
    await _database.SaveAsync();
    return "Create Ok";
});

app.Run();