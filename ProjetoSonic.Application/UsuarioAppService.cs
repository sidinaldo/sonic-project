
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoSonic.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
            : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IEnumerable<Usuario> ObterUsuarioEspecial()
        {
            return _usuarioService.ObterUsuarioEspecial(_usuarioService.GetAll());
        }

        //public void SetPassword(string senha, string ConfirmaSenha)
        //{
        //    if (string.IsNullOrEmpty(senha))
        //    {
        //        throw new Exception("Senha Inválida");
        //    }
        //}
    }
}
