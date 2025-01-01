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
builder.Services.AddDbContext<FunskoolsContext>(options =>
        options.UseSqlServer("Server=localhost;Database=test;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"));

//builder.Services.AddScoped<CustomAuthFilter>();
builder.Services.AddScoped<IActiveUserService, ActiveUserService>();

builder.Services.AddScoped<IAboutUsRepository, AboutUsRepository>();
builder.Services.AddScoped<IAboutUsService, AboutUsService>();

builder.Services.AddScoped<IBannerRepository, BannerRepository>();
builder.Services.AddScoped<IBannerService, BannerService>();

builder.Services.AddScoped<IBarcodeRepository, BarcodeRepository>();
builder.Services.AddScoped<IBarcodeService, BarcodeService>();

builder.Services.AddScoped<IBatchRepository, BatchRepository>();
builder.Services.AddScoped<IBatchService, BatchService>();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
builder.Services.AddScoped<IBuildingService, BuildingService>();

builder.Services.AddScoped<IClassRepository, ClassRepository>();
builder.Services.AddScoped<IClassService, ClassService>();

builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
builder.Services.AddScoped<IContactUsService, ContactUsService>();

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

builder.Services.AddScoped<IDomainRepository, DomainRepository>();
builder.Services.AddScoped<IDomainService, DomainService>();

builder.Services.AddScoped<IEmployementTypeRepository, EmployementTypeRepository>();
builder.Services.AddScoped<IEmployementTypeService, EmployementTypeService>();

builder.Services.AddScoped<IGenderRepository, GenderRepository>();
builder.Services.AddScoped<IGenderService, GenderService>();

builder.Services.AddScoped<IIssueBookStudentRepository, IssueBookStudentRepository>();
builder.Services.AddScoped<IIssueBookStudentService, IssueBookStudentService>();

builder.Services.AddScoped<ILoginTypeRepository, LoginTypeRepository>();
builder.Services.AddScoped<ILoginTypeService, LoginTypeService>();

builder.Services.AddScoped<IMaritalStatusRepository, MaritalStatusRepository>();
builder.Services.AddScoped<IMaritalStatusService, MaritalStatusService>();

builder.Services.AddScoped<IPaymentStatusRepository, PaymentStatusRepository>();
builder.Services.AddScoped<IPaymentStatusService, PaymentStatusService>();

builder.Services.AddScoped<ISocialCateogoryRepository, SocialCateogoryRepository>();
builder.Services.AddScoped<ISocialCateogoryService, SocialCateogoryService>();

builder.Services.AddScoped<IStaffTypeRepository, StaffTypeRepository>();
builder.Services.AddScoped<IStaffTypeService, StaffTypeService>();

builder.Services.AddScoped<IStudentCateogoryRepository, StudentCateogoryRepository>();
builder.Services.AddScoped<IStudentCateogoryService, StudentCateogoryService>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddScoped<IStudentSeatBookingRepository, StudentSeatBookingRepository>();
builder.Services.AddScoped<IStudentSeatBookingService, StudentSeatBookingService>();

builder.Services.AddScoped<IStudentSubTypeRepository, StudentSubTypeRepository>();
builder.Services.AddScoped<IStudentSubTypeService, StudentSubTypeService>();

builder.Services.AddScoped<ISubscriptionPackageRepository, SubscriptionPackageRepository>();
builder.Services.AddScoped<ISubscriptionPackageService, SubscriptionPackageService>();

builder.Services.AddScoped<ISubscriptionPaymentRepository, SubscriptionPaymentRepository>();
builder.Services.AddScoped<ISubscriptionPaymentService, SubscriptionPaymentService>();

builder.Services.AddScoped<ISubscriptionsTransactionRepository, SubscriptionsTransactionRepository>();
builder.Services.AddScoped<ISubscriptionsTransactionService, SubscriptionsTransactionService>();

builder.Services.AddScoped<IStaffRepository, StaffRepository>();
builder.Services.AddScoped<IStaffService, StaffService>();

builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICountryService, CountryService>();


// // Register Repository 
// builder.Services.AddScoped<IBookRepository, BookRepository>();
// builder.Services.AddScoped<IClassRepository, ClassRepository>();
// // builder.Services.AddScoped<IUserProfileRepository, UserProfileRepository>();
// builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
// builder.Services.AddScoped<IStudentRepository, StudentRepository>();
// //builder.Services.AddScoped<IStaffTypeRepository, StaffTypeRepository>();
// //builder.Services.AddScoped<ILoginTypeRepository, LoginTypeRepository>();

// // Register Services
// builder.Services.AddScoped<IBookService, BookService>();
// builder.Services.AddScoped<IClassService, ClassService>();
// // builder.Services.AddScoped<IUserProfileService, UserProfileService>();
// builder.Services.AddScoped<IBuildingService, BuildingService>();
// builder.Services.AddScoped<IStudentService, StudentService>();
// //builder.Services.AddScoped<IStaffTypeService, StaffTypeService>();
// //builder.Services.AddScoped<ILoginTypeService, LoginTypeService>();

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
