
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Domain.Interfaces.Repositories
{
    public interface IEstadoRepository : IRepositoryBase<Estado>
    {
        IEnumerable<Estado> BuscarPorNome(string nome);  //pesquisa e buscar por nome
    }
}
