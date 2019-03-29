using ProjetoSonic.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSonic.Infra.Data.EmtityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            // Mapear comportamento da indentidade dominio para a tabela da base de dados

            HasKey(u => u.UsuarioId);

            Property(u => u.NomeUsuario).IsRequired().HasMaxLength(150); //campo requerido e tamanho do campo
            Property(u => u.SenhaUsuario).IsRequired().HasMaxLength(15); //campo requerido e tamanho do campo
            Property(u => u.ClubeQueTorce).HasMaxLength(250); //campo requerido e tamanho do campo             
            Property(u => u.EmailUsuario).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("Idx_Usuario_Email") { IsUnique = true }));

            HasRequired(u => u.Bairro).WithMany().HasForeignKey(u => u.BairroId); //Relacionamento "Chave estrangeira"

           
        }
    }
}
