using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.API.Data
{
    public class DataContext : DbContext
    {
        /*dotnet add package Microsoft.EntityFrameworkCore.Design*/
        
        public DataContext  (DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }
    }
}