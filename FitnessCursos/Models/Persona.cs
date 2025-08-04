using Microsoft.AspNetCore.Identity;

namespace FitnessCursos.Models
{
    public class Persona : IdentityUser<string>
    {
        //public String Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public override string UserName
        {
            get => base.UserName;
            set => base.UserName = value;
        }
        public override string Email
        {
            get => base.Email;
            set => base.Email = value;
        }
        public DateTime FechaRegistracion { get; set; } = DateTime.Now;


    }
}
