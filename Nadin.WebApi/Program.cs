using MediatR;
using Microsoft.EntityFrameworkCore;
using Nadin.Application.CommandHandler.ProductCommandHandler;
using Nadin.Domain.Contract;
using Nadin.Infrastucture.Context;
using Nadin.Infrastucture.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepositories,ProductRepositories>();
//Mediater
builder.Services.AddMediatR(typeof(CreateProductCommandHandler).Assembly);
//add db context
builder.Services.AddDbContext<NadinContext>();
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
