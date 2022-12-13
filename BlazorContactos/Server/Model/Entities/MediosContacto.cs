using System.ComponentModel.DataAnnotations;

namespace BlazorContactos.Server.Models.Entities
{
    public class MediosContacto
    {
        
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Celular { get; set; }

    }
}
    