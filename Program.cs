var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // Esto le dice: "Busca mis archivos en la carpeta Controllers"
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Esto activa la página de prueba Swagger

var app = builder.Build();

// Configura la página de prueba (Swagger)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers(); // ¡Importante! Esto conecta tus archivos de la carpeta Controllers

app.Run(); // Esto enciende el servidor
