using Microsoft.EntityFrameworkCore;
using QuizGame.Infrastructure;
using QuizGame.API.Hubs;


var builder = WebApplication.CreateBuilder(args);

// Configuration du DbContext avec SQLite
builder.Services.AddDbContext<QuizGameDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapHub<GameHub>("/gamehub");
app.UseAuthorization();
app.MapControllers();
app.Run();