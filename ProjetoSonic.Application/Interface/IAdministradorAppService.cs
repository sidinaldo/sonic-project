using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Application.Interface
{
    public interface IAdministradorAppService : IAppServiceBase<Administrador>
    {
         IEnumerable<Administrador> BuscarPorFuncao(string funcao);        
    }
}
