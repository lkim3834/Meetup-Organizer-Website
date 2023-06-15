// set the models to global to use Character class
global using RestAPI_project.Models;
global using RestAPI_project.Services.CharacterService;
global using RestAPI_project.Dtos.Character;
global using AutoMapper;
global using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// register is added --> instance would be created in CharacterService file
builder.Services.AddAutoMapper(typeof(Program).Assembly);
//https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicecollectionserviceextensions.addscoped?view=dotnet-plat-ext-7.0
//AddScoped : Adds a scoped service of the type specified in serviceType to the specified IServiceCollection.
// then resolve service for type ICharacterService while attempting to activate CharacterService.
// AddTransient : add to all service 
builder.Services.AddScoped<ICharacterService, CharacterService>() ;

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
