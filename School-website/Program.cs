var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ? Custom Route for HomeController (No "Home" in URL)
app.MapControllerRoute(
    name: "home-custom",
    pattern: "{action=Index}/{id?}",
    defaults: new { controller = "Home" });


// ? Default Route for Everything Else
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.Run();
