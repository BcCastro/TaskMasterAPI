using TaskMasterAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var path = Path.Combine(Path.GetTempPath(), "TaskMaster.db");
builder.Services.AddSqlite<AppDbContext>($"Data Source={path}");


var app = builder.Build();

// --- ESTO ARREGLA EL ERROR 500 EN AZURE ---
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated(); // Crea la base de datos si no existe en el servidor
}
// ------------------------------------------

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskMaster API V1");
    c.RoutePrefix = string.Empty; 
});

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
