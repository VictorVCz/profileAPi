using Microsoft.EntityFrameworkCore;
using profileAPi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var DbConnectionString = builder.Configuration.GetConnectionString("DbConnection");

builder.Services.AddDbContext<DataContext>(
    option => option.UseSqlite(DbConnectionString)
);


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
