var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(
    "<html><body style='background-color:yellow;'><h1>Hello Lode's World! Cloud Ev</h1></body></html>",
    "text/html"
));

app.Run();
