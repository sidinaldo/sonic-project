using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class JogoJogadorEventoViewModel
    {
        [Key]
        public int JogoJogadorEventoId { get; set; }


        public int JogoId { get; set; }

        public int JogadorId { get; set; }

        public int EventoId { get; set; }

        public virtual JogadorViewModel Jogador { get; set; }

        public virtual JogoViewModel Jogo { get; set; }

        public virtual EventoViewModel Evento { get; set; }

        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }

    }
}