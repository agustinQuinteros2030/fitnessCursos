namespace FitnessCursos.Models
{
    public class ComentarioCurso
    {   // un usuario hace un comentario y otras personas pueden responder ese comentario
        public int Id { get; set; }
        public int CursoId { get; set; } // ID del curso al que pertenece la respuesta
        public Curso Curso { get; set; } // Navegación al curso
        public string UsuarioId { get; set; } // ID del usuario que hizo la respuesta
        public Usuario Usuario { get; set; } // Navegación al usuario
        public string Texto { get; set; } // Contenido de la respuesta
        public DateTime FechaCreacion { get; set; } = DateTime.Now; // Fecha de creación del comentario
        public List<RespuestaCurso> Respuestas { get; set; } = new List<RespuestaCurso>(); // Respuestas a este comentario
    }
}
