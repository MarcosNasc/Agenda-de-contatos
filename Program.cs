 using Agenda.Data;
using Agenda.Models;
using Agenda.Repository;
using Agenda.Repository.Iterfaces;
using Agenda.Services;
using Agenda.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigureServices(builder);

var app = builder.Build();
ConfigureApp(app); 

app.Run();

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();
    ConfigureDatabase(builder);
    builder.Services.AddScoped<IContatoService, ContatoService>();
    builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    builder.Services.AddSwaggerGen();
}

void ConfigureApp(WebApplication app)
{
    app.MapControllers();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwagger();
    }

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

void ConfigureDatabase(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<AgendaContext>(options => options.UseSqlServer(connectionString));
}