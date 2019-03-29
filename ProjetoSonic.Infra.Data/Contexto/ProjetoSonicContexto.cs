using ProjetoSonic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;

namespace ProjetoSonic.Infra.Data.Contexto
{
    public class ProjetoSonicContexto : DbContext
    {       
        public ProjetoSonicContexto()// construtor do contexto
               : base("ProjetoSonic")//string de conexão
        {

        }

        
        public DbSet<Usuario> Usuarios { get; set; } //
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
       // public DbSet<JogoJogadorEvento> JogoJogadorEventos { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<JogoJogador> JogoJogadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //convensão do nome da tabela do plural para o singular
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Não deleter em cascata quando tiver uma relação de 1 para n
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Não deleter em cascata quando tiver uma relação de n para n
          
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey()); //setar como PK todos os nomes + Id no final
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("Varchar")); //definir o tipo de dados da coluna do banco
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100)); // definir o tamanho da coluna
                                                                                   
            // Criar as Stored Procedures
            modelBuilder.Entity<Administrador>().MapToStoredProcedures();

            modelBuilder.Entity<Administrador>()
                .MapToStoredProcedures(p => p.Insert(sp => sp.HasName("sp_InsertAdministrador").Parameter(pm => pm.AdministradorId, "name").Result(rs => rs.AdministradorId, "AdministradorID"))
                .Update(sp => sp.HasName("sp_UpdateAdministrador").Parameter(pm => pm.AdministradorId, "name"))
                .Delete(sp => sp.HasName("sp_DeleteAdministrador").Parameter(pm => pm.AdministradorId, "Id"))
                );

            //----------------------------------------------------------------------------------------------------------------------

            modelBuilder.Configurations.Add(new EmtityConfig.UsuarioConfiguration());  //usar o que foi definido no método UsuarioConfiguration no projeto Data/EntityConfig/  
            modelBuilder.Configurations.Add(new EntityConfig.AdministradorConfiguration());  //usar o que foi definido no método AdministradorConfiguration  no projeto Data/EntityConfig/         
            modelBuilder.Configurations.Add(new EntityConfig.BairroConfiguration());  //usar o que foi definido no método BairroConfiguration  no projeto Data/EntityConfig/  
            modelBuilder.Configurations.Add(new EntityConfig.MunicipioConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/  
            modelBuilder.Configurations.Add(new EntityConfig.EstadoConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/  
            modelBuilder.Configurations.Add(new EntityConfig.EventoConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/ 
            modelBuilder.Configurations.Add(new EntityConfig.ClubeConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/  
            modelBuilder.Configurations.Add(new EntityConfig.JogadorConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/  
            modelBuilder.Configurations.Add(new EntityConfig.JogoConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/  
           // modelBuilder.Configurations.Add(new EntityConfig.JogoJogadorEventoConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/  
            modelBuilder.Configurations.Add(new EntityConfig.CampoConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/ 
            modelBuilder.Configurations.Add(new EntityConfig.FuncaoConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/   
            modelBuilder.Configurations.Add(new EntityConfig.JogoJogadorConfiguration());  //usar o que foi definido no método MunicipioConfiguration  no projeto Data/EntityConfig/   


            //modelBuilder.Entity<Jogador>()
            //     .HasMany<Jogo>(s => s.Jogos)
            //     .WithMany(c => c.Jogadores)
            //     .Map(cs =>
            //     {
            //         cs.MapLeftKey("JogadorId");
            //         cs.MapRightKey("JogoId");
            //         cs.ToTable("JogoJogador");
            //     });




}

        //data automática
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") 
                != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;

                }
            }
            return base.SaveChanges();
        }
    }
}
