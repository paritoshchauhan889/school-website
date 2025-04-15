using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using School_website.Data;
using School_website.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

var app = builder.Build();

// Register the lowercase URL middleware here
app.UseMiddleware<LowercaseUrlMiddleware>(); // This ensures the middleware runs early
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseHttpsRedirection();

// ? Custom Route for HomeController (No "Home" in URL)
//app.MapControllerRoute(
//    name: "home-custom",
//    pattern: "{action=Index}/{id?}",
//    defaults: new { controller = "Home" });

//// ? Default Route for Everything Else
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");

// Update your routing configuration
app.MapControllerRoute(
    name: "account",
    pattern: "Account/{action=Index}/{id?}",
    defaults: new { controller = "Account" });

// Then your home custom route
app.MapControllerRoute(
    name: "home-custom",
    pattern: "{action=Index}/{id?}",
    defaults: new { controller = "Home" });

// Default route for everything else
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.Run();

