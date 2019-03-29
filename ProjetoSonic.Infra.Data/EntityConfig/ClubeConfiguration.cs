
using System.Data.Entity.ModelConfiguration;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class ClubeConfiguration : EntityTypeConfiguration<Clube>
    {
        public ClubeConfiguration()
        {
            // Mapear comportamento da indentidade dominio para a tabela da base de dados

            HasKey(c => c.ClubeId);

            Property(c => c.NomeClube).IsRequired().HasMaxLength(150); //campo requerido e tamanho do campo
            Property(c => c.Historia).HasMaxLength(5000);

            HasRequired(c => c.Bairro).WithMany().HasForeignKey(c => c.BairroId); //Relacionamento "Chave estrangeira"

            //HasMany(c => c.Jogo).WithMany(c => c.).Map(c => {

            //    c.MapLeftKey("JogadorId");
            //    c.MapRightKey("JogoId");
            //    c.ToTable("ClubeJogoJogador");
            //});

                            
                                
                           

        }

    }
}
