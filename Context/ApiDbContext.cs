using ApiBuscaVoos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBuscaVoos.Context 
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        //talvez seja necessário adicionar a marcação de non nullable

        //public DbSet<Viagem> Viagens { get; set; }
        //public DbSet<Voo> Voos { get; set; }
        public DbSet<Aeroporto>? Aeroportos { get; set; }
    }
}
