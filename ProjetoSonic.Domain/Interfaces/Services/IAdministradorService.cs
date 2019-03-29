using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Services
{
    public interface IAdministradorService : IServiceBase<Administrador>
    {
        IEnumerable<Administrador> BuscarPorFuncao(string funcao);
    }
}
