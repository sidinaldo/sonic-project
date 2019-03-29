using System.Data.Entity.ModelConfiguration;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Infra.Data.EntityConfig
{
    public class AdministradorConfiguration : EntityTypeConfiguration<Administrador>
    {
        public AdministradorConfiguration()
        {
            HasKey(a => a.AdministradorId);
                                            
            Property(a => a.Ativo).IsRequired();//requerido 
            HasRequired(a => a.Usuario).WithMany().HasForeignKey(a => a.UsuarioId); //Relacionamento "Chave estrangeira"
            HasRequired(a => a.Funcao).WithMany().HasForeignKey(a => a.FuncaoId); //Relacionamento "Chave estrangeira"

        }
    }
}
