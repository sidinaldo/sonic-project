
using ProjetoSonic.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class JogoJogadorConfiguration : EntityTypeConfiguration<JogoJogador>
    {
        public JogoJogadorConfiguration()
        {
            HasKey(j => j.JogoJogadorId);
          
            HasRequired(j => j.Jogo).WithMany().HasForeignKey(j => j.JogoId); //Relacionamento "Chave estrangeira"
            HasRequired(j => j.Jogador).WithMany().HasForeignKey(j => j.JogadorId); //Relacionamento "Chave estrangeira"
        }
    }
}
