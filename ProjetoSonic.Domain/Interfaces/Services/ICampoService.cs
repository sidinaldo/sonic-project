using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Services
{
    public interface ICampoService : IServiceBase<Campo>
    {
        IEnumerable<Campo> BuscarPorNome(string nome);
    }
}
