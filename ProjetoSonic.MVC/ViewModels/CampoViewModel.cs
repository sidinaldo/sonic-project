using ProjetoSonic.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class CampoViewModel
    {
        [Key]
        public int CampoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Time B")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeCampo { get; set; }


        public int BairroId { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        public virtual BairroViewModel Bairro { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }       
     
       
    }
}