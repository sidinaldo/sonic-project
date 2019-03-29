
using System;
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoSonic.Domain.Services
{
    public class JogoService : ServiceBase<Jogo>, IJogoService
    {
        private readonly IJogoRepository _jogoRepository;

        public JogoService(IJogoRepository jogoRepository)
              : base(jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        public IEnumerable<Jogo> BuscarPorNome(string clube)
        {
            return BuscarPorNome(clube);
        }

        public IEnumerable<Jogo> JogoEspecial(IEnumerable<Jogo> jogo)
        {
            return JogoEspecial(jogo);
        }
    }
}
