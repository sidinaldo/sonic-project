
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.MVC.ViewModels
{
    public class MunicipioViewModel
    {
        [Key]
        public int MunicipioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeMunicipio { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        public virtual IEnumerable<Bairro> Bairro { get; set; }//classe município tem uma coleção de bairro

        public int EstadoId { get; set; }
        public virtual EstadoViewModel Estado { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }


    }
}