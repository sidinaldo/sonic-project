using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Application.Interface
{
    public interface IClubeAppService : IAppServiceBase<Clube>
    {
        IEnumerable<Clube> ClubeDoBairro(string bairro);  //pesuisa por clube da comunidade
    }
}
