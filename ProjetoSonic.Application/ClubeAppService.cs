using System;
using System.Collections.Generic;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class ClubeAppService : AppServiceBase<Clube>, IClubeAppService
    {
        private readonly IClubeService _clubeService;

        public ClubeAppService(IServiceBase<Clube> serviceBase, IClubeService clubeService) 
            : base(serviceBase)
        {
            _clubeService = clubeService;
        }

        public IEnumerable<Clube> ClubeDoBairro(string bairro)
        {
            return _clubeService.ClubeDoBairro(bairro);
        }
    }
}
