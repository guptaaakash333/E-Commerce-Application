using ECommerceAPI.Data;
using ECommerceAPI.Extensions;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;

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


// Register and configure JWT Bearer Authentication.
// JWT settings such as Key, Issuer, Audience,
// and token validation rules are read from configuration.
builder.Services.AddJwtAuthentication(builder.Configuration);

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

// Enable authentication middleware.
// This reads the JWT Bearer token from the incoming request,
// validates it, and creates the authenticated user identity.
// UseAuthentication() determines the identity of the Customer from the JWT Access Token.
app.UseAuthentication();

// Enable authorization middleware.
// After authentication identifies the user,
// authorization checks whether the user is allowed
// to access the requested protected resource.
// UseAuthorization() verifies whether the authenticated Customer is allowed to access a protected endpoint.
app.UseAuthorization();

app.MapControllers();

app.Run();
