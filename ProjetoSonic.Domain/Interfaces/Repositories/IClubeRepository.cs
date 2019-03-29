using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;

namespace ProjetoSonic.Domain.Interfaces.Repositories
{
    public interface IClubeRepository : IRepositoryBase<Clube>
    {
         IEnumerable<Clube> ClubeDoBairro(string bairro);  //pesquisa e buscar por função
       
    }
}
