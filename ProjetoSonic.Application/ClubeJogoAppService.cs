
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class ClubeJogoAppService : AppServiceBase<ClubeJogo>, IClubeJogoAppService
    {
        private readonly IClubeJogoService _clubeJogoService;

        public ClubeJogoAppService(IClubeJogoService clubeJogoService)
             : base(clubeJogoService)
        {
            _clubeJogoService = clubeJogoService;
        }

    }
}
