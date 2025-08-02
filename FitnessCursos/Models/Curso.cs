namespace FitnessCursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Icono { get; set; }
        public double Precio { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public Nivel Nivel { get; set; }
        public Estado estado { get; set; }
        public List<ComentarioCurso> Comentarios { get; set; } = new List<ComentarioCurso>();
        public List<RespuestaCurso> Respuestas { get; set; } = new List<RespuestaCurso>();

        public List<Clase>Clases { get; set; } = new List<Clase>();
        public List<Compra> Compras { get; set; } = new List<Compra>();
        public int CategoriaId { get; set; }
        public string InstructorId { get; set; }  
        public Usuario Instructor { get; set; }

    }
}
