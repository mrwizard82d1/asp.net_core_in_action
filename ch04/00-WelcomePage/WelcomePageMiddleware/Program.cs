var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// This application returns a default welcome page for **all** requests.
app.UseWelcomePage();

app.Run();