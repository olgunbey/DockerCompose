using Microsoft.EntityFrameworkCore;
using WEB.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<AppDbContext>(y => y.UseNpgsql("Host=postgres;Port=5432;Database=useradmin;Username=useradmin;Password=secret"));
builder.Services.AddSwaggerGen();
//builder.WebHost.UseUrls("https://0.0.0:80");
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
