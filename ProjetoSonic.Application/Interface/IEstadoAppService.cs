using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Application.Interface
{
    public interface IEstadoAppService : IAppServiceBase<Estado>
    {
        IEnumerable<Estado> BuscaPorNome(string nome);
    }
}
