
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Services
{
    public interface IBairroService : IServiceBase<Bairro>
    {
        IEnumerable<Bairro> BuscaPorNome(string nome);
    }
}
