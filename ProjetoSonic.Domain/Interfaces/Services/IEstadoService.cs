
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Domain.Interfaces.Services
{
    public interface IEstadoService : IServiceBase<Estado>
    {
        IEnumerable<Estado> BuscarPorNome(string nome);
    }
   
}
