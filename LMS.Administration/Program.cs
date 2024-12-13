using LMS.Administration.Filters;
using LMS.Administration.Middleware;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.LoginPath = "/Account/Login"; // Redirect here if not authenticated
        options.AccessDeniedPath = "/Account/AccessDenied";
    });
//builder.Services.AddRazorPages(options =>
//{
//    options.Conventions.ConfigureFilter(new CustomAuthFilter());
//});
builder.Services.AddDbContext<TestContext>(options =>
        options.UseSqlServer("Server=localhost;Database=test;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"));

//builder.Services.AddScoped<CustomAuthFilter>();
builder.Services.AddScoped<IActiveUserService, ActiveUserService>();

// Register Repository 
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IClassRepository, ClassRepository>();
builder.Services.AddScoped<IUserProfileRepository, UserProfileRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
//builder.Services.AddScoped<IStaffTypeRepository, StaffTypeRepository>();
//builder.Services.AddScoped<ILoginTypeRepository, LoginTypeRepository>();

// Register Services
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<IUserProfileService, UserProfileService>();
builder.Services.AddScoped<IBuildingService, BuildingService>();
//builder.Services.AddScoped<IStaffTypeService, StaffTypeService>();
//builder.Services.AddScoped<ILoginTypeService, LoginTypeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
//app.UseMiddleware<ActiveUserMiddleware>();
app.MapStaticAssets();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}")
//    .WithStaticAssets();
app.Run();
