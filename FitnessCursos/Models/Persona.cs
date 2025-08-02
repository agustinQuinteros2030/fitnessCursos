namespace FitnessCursos.Models
{
    public class Persona
    {
        public String Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistracion { get; set; } = DateTime.Now;


    }
}
