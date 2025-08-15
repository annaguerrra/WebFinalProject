using Microsoft.EntityFrameworkCore;
using WebFinalProject.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WebFinalProjectDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNECTION")
    )
);
var app = builder.Build();

app.Run();

