
using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Repositories
{
    public interface IJogoRepository : IRepositoryBase<Jogo>
    {
        //IEnumerable<Jogo> BuscarPorNome(string clube);  //pesquisa e buscar por função
    }
}
