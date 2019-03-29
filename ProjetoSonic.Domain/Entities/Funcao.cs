
using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
    public class Funcao
    {
        public int FuncaoId { get; set; }
        public string NomeFuncao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }
        public virtual IEnumerable<Administrador> Administradores { get; set; }
               
    }
}
