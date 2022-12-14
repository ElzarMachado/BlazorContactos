using System.ComponentModel.DataAnnotations;

namespace BlazorContactos.Server.Models.Entities
{
    public class Contacto
    {
        
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public int MediosContactosId { get; set; }
        public MediosContacto? MediosContacto { get; set; }
    }
}