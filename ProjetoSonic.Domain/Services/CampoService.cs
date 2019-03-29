
using System;
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class CampoService : ServiceBase<Campo>, ICampoService
    {
        private readonly ICampoRepository _campoRepository;

        public CampoService(ICampoRepository campoService)
            : base(campoService)
        {
            _campoRepository = campoService;
        }

        public IEnumerable<Campo> BuscarPorNome(string nome)
        {
            return _campoRepository.BuscarPorNome(nome);
        }
    }
}
