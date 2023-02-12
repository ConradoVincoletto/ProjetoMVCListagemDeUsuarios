using Microsoft.EntityFrameworkCore;
using ProjetoMvc.Models;

namespace ProjetoMvc.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
