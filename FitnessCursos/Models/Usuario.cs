namespace FitnessCursos.Models
{
    public class Usuario
    {
        public List<Curso> Cursos { get; set; } = new List<Curso>();
        public List<ComentarioCurso> Comentarios { get; set; } = new List<ComentarioCurso>();
        public List<RespuestaCurso> Respuestas { get; set; } = new List<RespuestaCurso>();
        public Carrito Carrito { get; set; } = new Carrito();
    }
}
