
using ProjetoSonic.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class CampoConfiguration : EntityTypeConfiguration<Campo>
    {
        public CampoConfiguration()
        {
            HasKey(c => c.CampoId);

            Property(c => c.NomeCampo).IsRequired().HasMaxLength(150);//requerido 
            HasRequired(c => c.Bairro).WithMany().HasForeignKey(c => c.BairroId); //Relacionamento "Chave estrangeira"
           
        }

    }
}
