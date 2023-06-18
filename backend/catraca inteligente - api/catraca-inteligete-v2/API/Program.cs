using API.Data;

using Applicaition.Interfaces;
using Applicaition.Mappers;
using Applicaition.Services;

using Domain.Repositories;

using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddUsers();
builder.Services.UniversityStudents();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserMapper, UserMapper>();
builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();

app.UseCors(x => x
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .SetIsOriginAllowed(origin => true) // allow any origin
                                                       //.WithOrigins("https://localhost:44351")); // Allow only this origin can also have multiple origins separated with comma
                   .AllowCredentials()); // allow credentials

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
