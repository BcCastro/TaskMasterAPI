using Microsoft.AspNetCore.Mvc;

namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    // Lista estática que se mantiene mientras el programa corre
    private static List<Tarea> tareas = new List<Tarea>();

    [HttpGet]
    public ActionResult<List<Tarea>> ObtenerTodas()
    {
        return Ok(tareas);
    }

    [HttpPost]
    public ActionResult CrearTarea(Tarea nuevaTarea)
    {
        tareas.Add(nuevaTarea);
        return Ok(new { mensaje = "¡Tarea guardada con éxito!", tarea = nuevaTarea });
    }
}
