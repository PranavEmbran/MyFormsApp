var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "HARI SHREE GANAPATHAYE NAMA:");
app.MapGet("/downloads", () => "Downloads URL");
app.MapPut("/", () => "This is a PUT");
app.MapDelete("/", () => "This is a Delete");
app.MapPost("/", () => "This is a Post");

app.Run();

