var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Info}/{id?}");

app.MapControllerRoute(
    name: "randomNumber",
    pattern: "random",
    defaults: new { controller = "Home", action = "RandomNumber" });

app.Run();