
using System.Data.Entity.ModelConfiguration;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class MunicipioConfiguration : EntityTypeConfiguration<Municipio>
    {
        public MunicipioConfiguration()
        {
            HasKey(m => m.MunicipioId);

            Property(m => m.NomeMunicipio).IsRequired().HasMaxLength(150); //requerido e o tamanho da coluna          
            

        }
    }
}
