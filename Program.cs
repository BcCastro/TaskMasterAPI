var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // Esto le dice: "Busca mis archivos en la carpeta Controllers"
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Esto activa la página de prueba Swagger

var app = builder.Build();

// BORRA EL "if" anterior y pega esto:
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskMaster API V1");
    c.RoutePrefix = string.Empty; // Esto hace que la API cargue directo en el link principal
});

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
