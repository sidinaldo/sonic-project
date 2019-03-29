
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Application.Interface
{
   public interface IUsuarioAppService : IAppServiceBase<Usuario> 
    {
        IEnumerable<Usuario> ObterUsuarioEspecial();
    }
}
