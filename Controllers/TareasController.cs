using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskMasterAPI.Models; 
namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    private readonly AppDbContext _context;

    // Conectamos el controlador con la Base de Datos
    public TareasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Tarea>>> ObtenerTodas()
    {
        return await _context.Tareas.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult> CrearTarea(Tarea nuevaTarea)
    {
        _context.Tareas.Add(nuevaTarea);
        await _context.SaveChangesAsync();
        return Ok(new { mensaje = "¡Guardado en base de datos!", tarea = nuevaTarea });
    }

    
}
