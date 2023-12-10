using Brewery_MSI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add DbContext with MySQL provider
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<MMABrewContext>(options =>
    //options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().WithMethods("POST", "PUT", "DELETE", "GET", "OPTIONS")
        .AllowAnyHeader();
    });
});

// ADDING THE DBCONTEXT TO THE SERVICE
builder.Services.AddDbContext<BitsContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Uses my static UI stuff, comment out later maybe idk. Rock and Stone!
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "Brewery-UI")),
    RequestPath = "/Brewery-UI"
});

app.UseAuthorization();

app.MapControllers();

app.Run();