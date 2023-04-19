using System.Reflection;
using UserService.Application.Interface;
using UserService.Application.Mapping;
using UserService.Application;
using UserService.Infrastructure;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using UserService.IdentityCommunication;
using static UserService.WebApi.Controllers.UsersController;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IContext).Assembly));
});

builder.Services.AddApplication();
builder.Services.AddPersistance(configuration);
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
builder.Services.AddIdentityCommunication(configuration);
builder.Services.AddHealthChecks();
builder.Services.AddControllers();


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviseProvider = scope.ServiceProvider;
    try
    {
        var context = serviseProvider.GetRequiredService<Context>();
        DbInit.init(context);
    }
    catch (Exception ex)
    {

    }
};



app.UseHealthChecks("/health", new HealthCheckOptions()
{
    Predicate = (_) => false
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
