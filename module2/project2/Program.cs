var builder = WebApplication.CreateBuilder(args);

// middleware should be added before building the app
// builder.Services.AddSession(options =>
// {
//   options.IdleTimeout = TimeSpan.FromSeconds(5);
//   options.Cookie.HttpOnly = true;
//   options.Cookie.IsEssential = true;
// });

// build the app
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// serves static file from wwwroot folder
// app.UseDefaultFiles();
// app.UseStaticFiles();

// configure the app to use session
// app.UseSession();

app.Run();
