
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Repositories
{
    public interface IBairroRepository : IRepositoryBase<Bairro>
    {
        IEnumerable<Bairro> BuscaPorNome(string nome);
    }
}
