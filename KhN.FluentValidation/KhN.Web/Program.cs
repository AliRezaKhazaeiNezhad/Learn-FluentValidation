using FluentValidation;
using KhN.Domain.Models;
using KhN.Domain.Validators;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
