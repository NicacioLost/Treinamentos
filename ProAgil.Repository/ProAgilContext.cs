using Microsoft.EntityFrameworkCore;


namespace ProAgil.Repository
{
    public class ProAgilContext : DbContext
    {
        /*dotnet add package Microsoft.EntityFrameworkCore.Design*/
        
        public ProAgilContext  (DbContextOptions<ProAgilContext> options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<RedeSocial> RedesSociais { get; set; }
        
        protectd override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.EntityFrameworkCore<PalestranteEvento>()
          .Haskey(PE => new {PE.EventoId, PE.PalestranteId});  
        }
    }
}