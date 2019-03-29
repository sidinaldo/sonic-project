
using System;
using System.Collections.Generic;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class CampoAppService : AppServiceBase<Campo>, ICampoAppService
    {
        private readonly ICampoService _campoService;

        public CampoAppService(ICampoService campoService)
            : base(campoService)
        {
            _campoService = campoService;
        }

        public IEnumerable<Campo> BuscarPorNome(string nome)
        {
            return _campoService.BuscarPorNome(nome);
        }
    }
}
