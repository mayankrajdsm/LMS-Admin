using LMS.Infrastructures.DataAccess;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TestContext>(options =>
        options.UseSqlServer("Server=localhost;Database=test;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"));

// Register Repository 
builder.Services.AddScoped<IBookRepository,BookRepository>();
builder.Services.AddScoped<IClassRepository,ClassRepository>();
builder.Services.AddScoped<IStudentRepository,StudentRepository>();
builder.Services.AddScoped<IUserProfileRepository, UserProfileRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();

// Register Services
builder.Services.AddScoped<IBookService,BookService>();
builder.Services.AddScoped<IClassService,ClassService>();
builder.Services.AddScoped<IStudentService,StudentService>();



builder.Services.AddScoped<IUserProfileService, UserProfileService>();
builder.Services.AddScoped<IBuildingService, BuildingService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
app.Run();
