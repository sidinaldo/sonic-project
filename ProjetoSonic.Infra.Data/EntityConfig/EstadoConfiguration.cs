using System.Data.Entity.ModelConfiguration;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            HasKey(e => e.EstadoId);
            Property(e => e.NomeEstado).IsRequired().HasMaxLength(150);
            Property(e => e.Sigla).IsRequired().HasMaxLength(2).HasColumnType("char");
        }
    }
}
