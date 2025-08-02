namespace FitnessCursos.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public List<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
