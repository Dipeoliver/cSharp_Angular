using Microsoft.EntityFrameworkCore;
using PROEVENTOS.API.Model;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        
        public DbSet<Evento> Eventos { get; set; }

        public DataContext (DbContextOptions<DataContext> options) :base(options){}
    }
}