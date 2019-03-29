
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class AdministradorViewModel
    {
        [Key]
        public int AdministradorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Função")]
        public int FuncaoId { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataFim { get; set; }

        public bool Ativo { get; set; }

        public int UsuarioId { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }      
       
        public virtual FuncaoViewModel Funcao { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }
    }
}