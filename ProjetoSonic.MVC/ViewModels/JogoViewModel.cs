
using ProjetoSonic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class JogoViewModel
    {   
        
        [Key]
        public int JogoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Time A")]        
        public int TimeA { get; set; }

        [Required(ErrorMessage = "Preencha o campo Time B")]       
        public int TimeB { get; set; }

        public DateTime DataJogo { get; set; }

        public string HoraJogo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        public int BairroId { get; set; }
        public virtual BairroViewModel Bairro { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Campo")]
        public int CampoId { get; set; }
        public virtual CampoViewModel Campo { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        public virtual ClubeViewModel Clube { get; set; }

        public int GolTimeA { get; set; }
        public int GolTimeB { get; set; }
        public string ResultadoTimeA { get; set; }
        public string ResultadoTimeB { get; set; } 

        //public virtual IEnumerable<Clube> Clubes { get; set; }
        public virtual IEnumerable<Jogador> Jogadores { get; set; }
        public virtual IEnumerable<JogoJogador> JogoJogadores { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }

        public virtual IEnumerable<JogoJogadorEvento> JogoJogadorEvento { get; set; }
    }
}