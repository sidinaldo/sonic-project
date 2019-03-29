
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        IEnumerable<Usuario> ObterUsuarioEspecial(IEnumerable<Usuario> usuario);// retornar uma lista de usuario especiais
    }
}
