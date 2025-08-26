using Microsoft.EntityFrameworkCore;
using TodoList.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TodoListContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.Run();
