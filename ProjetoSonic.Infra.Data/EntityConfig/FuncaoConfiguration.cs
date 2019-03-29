
using ProjetoSonic.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class FuncaoConfiguration : EntityTypeConfiguration<Funcao>
    {
        public FuncaoConfiguration()
        {
            HasKey(f => f.FuncaoId);

            Property(f => f.NomeFuncao).IsRequired().HasMaxLength(100);//requerido           
           
        }
    }
}
