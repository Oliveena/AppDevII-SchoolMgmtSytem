using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models.Users;
using SchoolManagementSystem.Patterns.Interfaces;
using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Patterns.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Identity DB context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// School/business DB context
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDb")));

// Dependency injection
builder.Services.AddScoped<SchoolManagementSystem.Patterns.Interfaces.IGradeRepository, GradeRepository>();
builder.Services.AddScoped<GradebookService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
