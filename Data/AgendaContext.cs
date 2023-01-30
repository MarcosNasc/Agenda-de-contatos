using Agenda.Data.Mappings;
using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMap());
        }
    }
}
