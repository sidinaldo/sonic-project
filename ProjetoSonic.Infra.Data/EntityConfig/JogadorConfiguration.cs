using ProjetoSonic.Domain.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class JogadorConfiguration : EntityTypeConfiguration<Jogador>
    {
        public JogadorConfiguration()
        {
            HasKey(j => j.JogadorId);
                                        
            HasRequired(j => j.Usuario).WithMany().HasForeignKey(j => j.UsuarioId); //Relacionamento "Chave estrangeira"
            HasRequired(j => j.Clube).WithMany().HasForeignKey(j => j.ClubeId); //Relacionamento "Chave estrangeira"
           
        }
    }
}
