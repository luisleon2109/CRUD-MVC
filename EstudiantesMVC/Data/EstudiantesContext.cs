using Microsoft.EntityFrameworkCore;
using EstudiantesMVC.Models;

namespace EstudiantesMVC.Data
{
    public class EstudiantesContext : DbContext
    {
        public EstudiantesContext(DbContextOptions<EstudiantesContext> options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
