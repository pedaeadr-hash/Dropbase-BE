using Microsoft.EntityFrameworkCore;
using DbContextspace;
var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<_Context>();

var app = builder.Build();




app.Run();

