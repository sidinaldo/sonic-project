using System.Data.Entity.ModelConfiguration;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
   public class BairroConfiguration : EntityTypeConfiguration<Bairro>
   {
       public BairroConfiguration()
       {
            // Mapear comportamento da indentidade dominio para a tabela da base de dados

            HasKey(b => b.BairroId);

            Property(b => b.NomeBairro).IsRequired().HasMaxLength(150); //campo requerido e tamanho do campo
            HasRequired(b => b.Municipio).WithMany().HasForeignKey(b => b.MunicipioId); //Relacionamento "Chave estrangeira"


        }
    }
}
