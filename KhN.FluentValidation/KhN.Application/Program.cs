using FluentValidation;
using KhN.Domain.Models;
using KhN.Domain.Validators;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
       .Services
       .AddControllers();
builder
       .Services
       .AddMvc()
       .AddFluentValidation(current =>
                            current
                                    .RegisterValidatorsFromAssemblyContaining<PersonValidator>());
builder
       .Services
       .AddTransient<IValidator<Person>, PersonValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
