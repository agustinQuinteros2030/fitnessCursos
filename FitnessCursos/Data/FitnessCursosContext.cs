using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using FitnessCursos.Models;

namespace FitnessCursos.Data
{
    public class FitnessCursosContext : IdentityDbContext<IdentityUser<string>, IdentityRole<string>, string>
    {

        public FitnessCursosContext(DbContextOptions<FitnessCursosContext> options) : base(options)
        {
        }
       public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ComentarioCurso> ComentariosCursos { get; set; }
        public DbSet<Compra> compras { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<RespuestaCurso> RespuestasCursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Rol> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ComentarioCurso → Curso (1 a muchos)
            modelBuilder.Entity<ComentarioCurso>()
                .HasOne(c => c.Curso)
                .WithMany(curso => curso.Comentarios)
                .HasForeignKey(c => c.CursoId)
                .OnDelete(DeleteBehavior.Cascade);

            // ComentarioCurso → Usuario (1 a muchos)
            modelBuilder.Entity<ComentarioCurso>()
                .HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            // RespuestaCurso → ComentarioCurso (1 a muchos)
            modelBuilder.Entity<RespuestaCurso>()
                .HasOne(r => r.ComentarioCurso)
                .WithMany(c => c.Respuestas)
                .HasForeignKey(r => r.ComentarioCursoId)
                .OnDelete(DeleteBehavior.Cascade);

            // RespuestaCurso → Usuario (1 a muchos)
            modelBuilder.Entity<RespuestaCurso>()
                .HasOne(r => r.Usuario)
                .WithMany()
                .HasForeignKey(r => r.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }

}
