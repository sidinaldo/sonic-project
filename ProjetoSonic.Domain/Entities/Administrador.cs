using System;

namespace ProjetoSonic.Domain.Entities
{
   public class Administrador
    {
       
        public int AdministradorId { get; set; }
        public int FuncaoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Funcao Funcao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }

    }
}
