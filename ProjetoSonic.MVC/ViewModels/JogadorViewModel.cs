
using ProjetoSonic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class JogadorViewModel
    {
        [Key]
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Jogador")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeJogador { get; set; }

        public string ApelidoJogador { get; set; }

        public string AlturaJogador { get; set; }

        public float PesoJogador { get; set; }

        public DateTime DataNascimneto { get; set; }

        public string PeDominante { get; set; }

        public string Posicaojogador { get; set; }

        public int UsuarioId { get; set; }

        public int ClubeId { get; set; }


        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }

        public virtual ClubeViewModel Clube { get; set; }

        public virtual IEnumerable<JogoJogadorEvento> JogoJogadorEvento { get; set; }
    }
}