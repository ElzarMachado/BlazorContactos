using System.ComponentModel.DataAnnotations;

namespace BlazorContactos.Server.Models.Entities
{
    public class Imagen
    {

        public int Id { get; set; }

        [Required]
        public string Foto { get; set; }

        public int MediosContactosId { get; set; }
        public MediosContacto? MediosContacto { get; set; }

    }
}