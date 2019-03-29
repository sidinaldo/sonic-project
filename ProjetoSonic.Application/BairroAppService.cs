using System;
using System.Collections.Generic;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class BairroAppService : AppServiceBase<Bairro>, IBairroAppService
    {
        private readonly IBairroService _bairroService;

        public BairroAppService(IBairroService bairroService)
            : base(bairroService)
        {
            _bairroService = bairroService;
        }

        public IEnumerable<Bairro> BuscaPorNome(string nome)
        {
            return _bairroService.BuscaPorNome(nome);
        }
    }
}
