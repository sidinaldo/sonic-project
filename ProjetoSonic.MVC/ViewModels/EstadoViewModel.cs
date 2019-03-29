
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.MVC.ViewModels
{
    public class EstadoViewModel
    {
        [Key]
        public int EstadoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]       
        public string NomeEstado { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sigla")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]
        public string Sigla { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Municipio> Municipio { get; set; }//classe Estado tem uma coleção de Municipio  

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }
       

    }
}