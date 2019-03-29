using System;
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class BairroService : ServiceBase<Bairro>, IBairroService
    {
        private readonly IBairroRepository _bairroRepository;

        public BairroService(IBairroRepository bairroRepository)
            : base(bairroRepository)
        {
            _bairroRepository = bairroRepository;
        }

        public IEnumerable<Bairro> BuscaPorNome(string nome)
        {
            return _bairroRepository.BuscaPorNome(nome);
        }
    }
}
