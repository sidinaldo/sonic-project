
using System.ComponentModel.DataAnnotations;

namespace ProjetoSonic.MVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Preencha o campo Usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        public string Senha { get; set; }

        public bool Lembrar { get; set; }

        [ScaffoldColumn(false)]
        public int IdSessao { get; set; }

        //public virtual UsuarioViewModel Usuario { get; set; }
    }
}