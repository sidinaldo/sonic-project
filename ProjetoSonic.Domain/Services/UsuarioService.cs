
using System;
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces;
using ProjetoSonic.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoSonic.Domain.Services
{
    public class UsuarioService  : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        
        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> ObterUsuarioEspecial(IEnumerable<Usuario> usuario)
        {
           return usuario.Where(u => u.ClubeQueTorce == "Olho D'água Futebol Clube").Where(u => u.Ativo);
        }

        //public void SetPassword()
        //{
        //    if (string.IsNullOrEmpty(senha))
        //    {
        //        throw new Exception("Senha Inválida");
        //    }
        //}
    }
}
