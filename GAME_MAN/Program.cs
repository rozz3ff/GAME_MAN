using GAME_MAN.Data;
using Microsoft.EntityFrameworkCore; // ���������� Entity Framework Core

var builder = WebApplication.CreateBuilder(args);

// ��������� ��������� ���� ������ � ��������� ������ �����������
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GameDB")));

// ��������� ��������� ������������
builder.Services.AddControllers();

// ������ ����������
var app = builder.Build();

app.UseDefaultFiles();

app.UseStaticFiles();


// ��������� HTTP-���������
app.UseHttpsRedirection();
app.UseAuthorization();

// ����������� ������������� ������������
app.MapControllers();

// ��������� ����������
app.Run();

