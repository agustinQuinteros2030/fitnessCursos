using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FitnessCursos.Models
{
    public class Rol : IdentityRole<String>
    {
        public Rol() : base()
        {

        }

        public Rol(string name) : base(name)
        {

        }
        public int Id { get; set; }
        public override string Name
        {
            get => base.Name;
            set => base.Name = value;
        }

        public override string NormalizedName { get => base.NormalizedName; set => base.NormalizedName = value; }
    }
}
    

