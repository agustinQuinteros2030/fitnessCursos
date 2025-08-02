namespace FitnessCursos.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime FechaCompra { get; set; } = DateTime.Now;
        public double Monto { get; set; }
        public string UsuarioId { get; set; } //datos del comprador
        public Usuario Usuario { get; set; }
        public int CursoId { get; set; } //datos del curso comprado
        public Curso Curso { get; set; }
    }
}
