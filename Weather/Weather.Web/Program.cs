using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Weathers}/{action=Index}/{id?}"
    );

app.Run();
