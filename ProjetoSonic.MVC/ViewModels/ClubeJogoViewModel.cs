using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class ClubeJogoViewModel
    {
        [Key]
        public int ClubeJogoId { get; set; }
        public int JogoId { get; set; }
        public int ClubeId { get; set; }
        public virtual ClubeViewModel Clube { get; set; }
        public virtual JogoViewModel Jogo { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public int IdSessao { get; set; }
       
    }
}