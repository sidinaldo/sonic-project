
using System.Data.Entity.ModelConfiguration;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class EventoConfiguration : EntityTypeConfiguration<Evento>
    {
        public EventoConfiguration()
        {
            HasKey(e => e.EventoId);

            Property(e => e.NomeEvento).IsRequired().HasMaxLength(150); //requerido e o tamanho da coluna
        }
    }
}
