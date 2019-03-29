using ProjetoSonic.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces.Services
{
    public interface IJogoService : IServiceBase<Jogo>
    {
        IEnumerable<Jogo> JogoEspecial(IEnumerable<Jogo> jogo);// retornar uma lista de usuario especiais
        IEnumerable<Jogo> BuscarPorNome(string clube);  //pesquisa e buscar por função
    }
}
