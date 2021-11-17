var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.MapControllerRoute(name: "Index", pattern: "{controller=Home}/{action=Index}");


app.Run();
