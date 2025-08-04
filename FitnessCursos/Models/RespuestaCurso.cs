namespace FitnessCursos.Models
{
    public class RespuestaCurso
    {
        public int Id { get; set; }
        public int ComentarioCursoId { get; set; }
        public ComentarioCurso ComentarioCurso { get; set; } // Relación con el comentario al que responde
        public string UsuarioId { get; set; } // ID del usuario que hizo la respuesta
        public Usuario Usuario { get; set; } // Navegación al usuario
        public string Texto { get; set; } // Contenido de la respuesta
        public DateTime FechaCreacion { get; set; } = DateTime.Now; // Fecha de creación de la respuesta

    }
}
