namespace FitnessCursos.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public string Titulo { get; set; }
        public string ContenidoHtml { get; set; }  // Texto, imágenes, etc.
        public string VideoUrl { get; set; }       // Link al video

        public int Orden { get; set; }  // 1, 2, 3... para ordenarlas
        public bool EsPreview { get; set; } = false;  // libre acceso si es true
    }
}

