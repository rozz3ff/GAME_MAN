using GAME_MAN.Data;
using Microsoft.EntityFrameworkCore; // Подключаем Entity Framework Core

var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку базы данных и указываем строку подключения
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GameDB")));

// Добавляем поддержку контроллеров
builder.Services.AddControllers();

// Строим приложение
var app = builder.Build();

app.UseDefaultFiles();

app.UseStaticFiles();


// Настройка HTTP-конвейера
app.UseHttpsRedirection();
app.UseAuthorization();

// Подключение маршрутизации контроллеров
app.MapControllers();

// Запускаем приложение
app.Run();

