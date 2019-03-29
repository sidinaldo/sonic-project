using ProjetoSonic.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoSonic.Application.Interface
{
    public interface IJogoAppService : IAppServiceBase<Jogo>
    {
        IEnumerable<Jogo> JogoEspecial(IEnumerable<Jogo> jogo);// retornar uma lista de jogo especiais
    }
}
