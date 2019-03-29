
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Repositories
{
    public interface ICampoRepository : IRepositoryBase<Campo>
    {
       IEnumerable<Campo> BuscarPorNome(string nome);
    }
}
