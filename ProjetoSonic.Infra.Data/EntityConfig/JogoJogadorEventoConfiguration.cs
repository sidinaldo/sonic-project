using ProjetoSonic.Domain.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class JogoJogadorEventoConfiguration : EntityTypeConfiguration<JogoJogadorEvento>
    {
        public JogoJogadorEventoConfiguration()
        {
            HasKey(j => j.JogoJogadorEventoId);
              
            HasRequired(j => j.Jogo).WithMany().HasForeignKey(j => j.JogoId); //Relacionamento "Chave estrangeira"
            HasRequired(j => j.Jogador).WithMany().HasForeignKey(j => j.JogadorId); //Relacionamento "Chave estrangeira"
            HasRequired(j => j.Evento).WithMany().HasForeignKey(j => j.EventoId); //Relacionamento "Chave estrangeira"
        }
    }
}
