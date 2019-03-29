
using ProjetoSonic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class EventoViewModel
    {
        [Key]
        public int EventoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeEvento { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }
               
        public virtual IEnumerable<JogoJogadorEvento> JogoJogadorEvento { get; set; }

    }
}