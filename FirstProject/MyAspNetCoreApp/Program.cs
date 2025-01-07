using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using MyAspNetCoreApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Ma'lumotlar bazasi ulanishini qo'shish
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Xizmatlarni qo‘shish
builder.Services.AddControllers();

var app = builder.Build();

// Middleware sozlash
app.UseRouting();
app.UseAuthorization();

// Marshrutlarni sozlash
app.MapControllers();

app.Run();

