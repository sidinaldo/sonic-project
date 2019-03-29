using ProjetoSonic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class ClubeViewModel
    {
        [Key]
        public int ClubeId { get; set; }


        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeClube { get; set; }

      
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Fundacao { get; set; }

        public int BairroId { get; set; }
        public virtual BairroViewModel Bairro { get; set; }

        [MaxLength(5000, ErrorMessage = "Máximo {0} caractéres")]
        public string Historia { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }
      
        public virtual IEnumerable<Jogador> Jogador { get; set; }//classe clube tem uma coleção de jogador
        public virtual IEnumerable<Jogo> Jogo { get; set; }

    }
}