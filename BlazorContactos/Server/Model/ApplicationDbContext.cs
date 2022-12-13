
using BlazorContactos.Server.Model;
using BlazorContactos.Server.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorContactos.Server.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Contacto> Contacto { get; set; }

        public DbSet<MediosContacto> MediosContacto { get; set; }
    }
}
