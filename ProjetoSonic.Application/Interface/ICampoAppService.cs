
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Application.Interface
{
    public interface ICampoAppService : IAppServiceBase<Campo>
    {
        IEnumerable<Campo> BuscarPorNome(string nome);
    }
}
