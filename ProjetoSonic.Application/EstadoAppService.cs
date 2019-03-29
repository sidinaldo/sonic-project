
using System;
using System.Collections.Generic;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class EstadoAppService : AppServiceBase<Estado>, IEstadoAppService
    {
        private readonly IEstadoService _estadoAppService;

        public EstadoAppService(IEstadoService estadoService)
            : base(estadoService)
        {
            _estadoAppService = estadoService;
        }

        public IEnumerable<Estado> BuscaPorNome(string nome)
        {
            return _estadoAppService.BuscarPorNome(nome);
        }
    }
}
