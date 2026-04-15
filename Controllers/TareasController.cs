using Microsoft.AspNetCore.Mvc;

namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    // Datos de prueba para ver que funciona
    private static List<Tarea> tareas = new List<Tarea>
    {
        new Tarea { Id = 1, Titulo = "Mi primer proyecto Pro", EstaCompletada = false },
        new Tarea { Id = 2, Titulo = "Desplegar en Azure", EstaCompletada = false }
    };

    [HttpGet]
    public ActionResult<List<Tarea>> Get()
    {
        return Ok(tareas);
    }
}
