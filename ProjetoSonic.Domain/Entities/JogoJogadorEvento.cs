
using System;

namespace ProjetoSonic.Domain.Entities
{
    public class JogoJogadorEvento
    {
        public int JogoJogadorEventoId { get; set; }
        public int JogoId { get; set; }
        public int JogadorId { get; set; }
        public int EventoId { get; set; }
        public int QuantidadeEvento { get; set; }
        public virtual Jogador Jogador { get; set; }
        public virtual Jogo Jogo { get; set; }
        public virtual Evento Evento { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }


    }
}
