
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.MVC.ViewModels
{
    public class BairroViewModel
    {
        [Key]
        public int BairroId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Bairro")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeBairro { get; set; }

        public int MunicipioId { get; set; }

        public virtual MunicipioViewModel Municipio { get; set; }

        public virtual IEnumerable<Usuario> Usuario { get; set; }//classe bairro tem uma coleção de usuários
        public virtual IEnumerable<Clube> Clube { get; set; }//classe bairro tem uma coleção de clubes
        public virtual IEnumerable<Jogo> Jogo { get; set; }//classe bairro tem uma coleção de jogos
        public virtual IEnumerable<Campo> Campo { get; set; }//classe bairro tem uma coleção de Campo

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }
      
        
        
    }
}