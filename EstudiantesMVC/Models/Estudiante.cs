namespace EstudiantesMVC.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Rol { get; set; }

        // Propiedad calculada para nombre completo
        public string NombreCompleto => $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}";
    }
}

