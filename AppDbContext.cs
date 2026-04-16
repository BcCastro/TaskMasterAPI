using Microsoft.EntityFrameworkCore;
using TaskMasterAPI.Models;

namespace TaskMasterAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Esta línea crea la tabla de base de datos basada en la clase Tarea
    public DbSet<Tarea> Tareas => Set<Tarea>();
}
