
using ProjetoSonic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class FuncaoViewModel
    {
        [Key]
        public int FuncaoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Função")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeFuncao { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }

        public virtual IEnumerable<Administrador> Administrador { get; set; }
    }
}