var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging((o) => { });

var app = builder.Build();

app.UseHttpLogging(); //Middleware for logging. Add HttpLoggingMiddleware to appsettings.json

// app.UseRouting();  // This is a default middleware used by ASP.Net
// app.UseAuthentication();  // This is a default middleware used by ASP.Net
// app.UseAuthorization();  // This is a default middleware used by ASP.Net
// app.UseExceptionHandler();  // This is a default middleware used by ASP.Net

app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Path}");
    Console.WriteLine("Logic before(1)");
    await next();
    /*
    await next(); Invokes the next middleware component in the request pipeline
    Waits asynchronously for it to complete
    After the next middleware (and all subsequent ones) finish, execution returns to line "Logic after(1)".
    */
    Console.WriteLine($"Response: {context.Response.StatusCode}");
    Console.WriteLine("Logic after(1)");
});


//Custom Middleware:
app.Use(async (context, next) =>
{
    Console.WriteLine("Logic before(2)");
    await next();
    Console.WriteLine("Logic after(2)");
});

app.MapGet("/", () => "Hello World!");
app.MapGet("/home", () => "Welcome Home");

// app.UseEndpoints();  // This is a default middleware used by ASP.Net

app.Run();
