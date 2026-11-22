var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Endpoint de salud usado por Docker Compose y las pruebas de humo.
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.Run();

// Permite usar WebApplicationFactory<Program> en las pruebas de integración.
public partial class Program;
