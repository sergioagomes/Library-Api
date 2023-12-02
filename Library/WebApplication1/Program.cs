using Library.Data;
using Library.Service;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

//Conection with Database
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var server = builder.Configuration["DbServer"] ?? "localhost";
var port = builder.Configuration["DbPort"] ?? "3306";
var user = builder.Configuration["DbUser"] ?? "root";
var password = builder.Configuration["Password"] ?? "root";
var database = builder.Configuration["Database"] ?? "LibraryDb";

var connectionString = builder.Configuration.GetConnectionString("BooksConnection");

builder.Services.AddDbContext<MysqlContext>(opts => 
                        opts.UseLazyLoadingProxies().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//

builder.Services.
AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddNewtonsoftJson();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//create migration on container
//DatabaseManagementService.MigrationInitialisation(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
