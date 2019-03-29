
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Application.Interface
{
    public interface IBairroAppService : IAppServiceBase<Bairro>
    {
        IEnumerable<Bairro> BuscaPorNome(string nome);
    }
}
