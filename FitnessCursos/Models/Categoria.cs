namespace FitnessCursos.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public string Icono { get; set; }
        public List<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
