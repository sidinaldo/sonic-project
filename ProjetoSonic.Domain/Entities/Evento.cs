
using System;

namespace ProjetoSonic.Domain.Entities
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string NomeEvento { get; set; }
        public DateTime DataCadastro { get; set; }      
        public int IdSessao { get; set; }
        //public virtual IEnumerable<JogoJogadorEvento> JogoJogadorEvento { get; set; }
        
    }
}
