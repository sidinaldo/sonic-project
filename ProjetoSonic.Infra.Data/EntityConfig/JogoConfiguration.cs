using ProjetoSonic.Domain.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class JogoConfiguration : EntityTypeConfiguration<Jogo>
    {
        public JogoConfiguration()
        {
            HasKey(j => j.JogoId);

            Property(j => j.BairroId);            
            Property(j => j.DataJogo).IsRequired();//requerido
            Property(j => j.HoraJogo).IsRequired();//requerido
            //Property(j => j.TimeA).IsRequired().HasMaxLength(100);//requerido   
            //Property(j => j.TimeB).IsRequired().HasMaxLength(100);//requerido     
            Property(j => j.GolTimeA).IsRequired();//requerido
            Property(j => j.GolTimeB).IsRequired();//requerido
                        
            HasRequired(j => j.Bairro).WithMany().HasForeignKey(j => j.BairroId); //Relacionamento "Chave estrangeira"
            HasRequired(j => j.Campo).WithMany().HasForeignKey(j => j.CampoId); //Relacionamento "Chave estrangeira"
            HasRequired(j => j.Clube).WithMany().HasForeignKey(j => j.TimeA); //Relacionamento "Chave estrangeira"
            HasRequired(j => j.Clube).WithMany().HasForeignKey(j => j.TimeB); //Relacionamento "Chave estrangeira"



        }
    }
}
