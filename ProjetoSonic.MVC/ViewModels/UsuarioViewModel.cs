using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ProjetoSonic.MVC.ViewModels
{
    public class UsuarioViewModel
    {
       
        // ViewModels não pode ter comportamentos, elas são representações.
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres" )]
        [MinLength (2, ErrorMessage = "Mínimo {0} caractéres")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail válido")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string EmailUsuario { get; set; }

       
        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(15, ErrorMessage = "A Senha não pode ser maior que 15 caractéres" )]
        [MinLength(6, ErrorMessage = "A senha tem que ter no mínimo 6 caractéres ")]
        [ScaffoldColumn(false)] //campo não vai ser criado
        public string SenhaUsuario { get; set; }

        
        [Required(ErrorMessage = "Preencha o campo Tipo")]
        [ScaffoldColumn(false)] //campo não vai ser criado
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Time")]
        public string ClubeQueTorce { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        public int BairroId { get; set; }
        public virtual BairroViewModel Bairro { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)] //campo não vai ser criado
        public DateTime DataCadastro { get; set; }
        
        public virtual IEnumerable<AdministradorViewModel> Administrador { get; set; }//classe usuaio tem uma coleção de Administradores

        public virtual IEnumerable<LoginViewModel> Login { get; set; }//classe usuaio tem uma coleção de Administradores

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }
    }
}