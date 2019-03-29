
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Domain.Interfaces.Services
{
    public interface IClubeService : IServiceBase<Clube>
    {
        IEnumerable<Clube> ClubeDoBairro(string bairro);  //pesuisa por clube da comunidade
    }
}
