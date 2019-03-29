using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces
{
    public interface IAdministradorRepository : IRepositoryBase<Administrador>
    {
        IEnumerable<Administrador> BuscarPorFuncao(string funcao);  //pesquisa e buscar por função
    }
}
