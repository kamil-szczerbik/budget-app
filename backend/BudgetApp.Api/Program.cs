using BudgetApp.Api;
using BudgetApp.Infrastructure;
using BudgetApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddDbContext<AppDbContext>(options =>
        options
            .UseNpgsql(builder.Configuration.GetConnectionString("BudgetDb"))
            .UseSnakeCaseNamingConvention()
        );

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact", policy =>
    {
        policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options
            .WithTitle("Budget API")
            .WithTheme(ScalarTheme.Laserwave)
            ;
    });
}

app.UseCors("AllowReact");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
