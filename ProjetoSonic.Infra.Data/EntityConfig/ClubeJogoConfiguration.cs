
using ProjetoSonic.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class ClubeJogoConfiguration : EntityTypeConfiguration<ClubeJogo>
    {
        public ClubeJogoConfiguration()
        {
            HasKey(c => c.ClubeJogoId);

           
            HasRequired(c => c.Clube).WithMany().HasForeignKey(c => c.ClubeId); //Relacionamento "Chave estrangeira"
            HasRequired(c => c.Jogo).WithMany().HasForeignKey(c => c.JogoId); //Relacionamento "Chave estrangeira"
        }
    }
}
