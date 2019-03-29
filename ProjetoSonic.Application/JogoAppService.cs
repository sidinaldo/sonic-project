using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoSonic.Application
{
    public class JogoAppService : AppServiceBase<Jogo>, IJogoAppService
    {
        private readonly IJogoService _jogoService;

        public JogoAppService(IJogoService jogoService)
            : base(jogoService)
        {
            _jogoService = jogoService;
        }

        public IEnumerable<Jogo> JogoEspecial(IEnumerable<Jogo> jogo)
        {
            return _jogoService.JogoEspecial(jogo);
        }

        public IEnumerable<Jogo> BuscarPorNome(string clube)
        {
            return _jogoService.BuscarPorNome(clube);
        }
    }
}
