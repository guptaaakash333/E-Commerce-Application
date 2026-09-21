using ECommerceAPI.Data;
using ECommerceAPI.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ECommerceDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDBConnection"));
});

// Register all repository services using the extension method.
builder.Services.AddRepositories(); 

// Register the application's global exception handler.
// This allows unhandled exceptions from the application
// to be processed by GlobalExceptionHandler.
builder.Services.AddGlobalExceptionHandling();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Add the global exception handling middleware
// to the HTTP request pipeline.
// When an unhandled exception occurs,
// ASP.NET Core forwards it to the registered exception handler.
app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
