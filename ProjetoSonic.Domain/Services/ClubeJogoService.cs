
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class ClubeJogoService : ServiceBase<ClubeJogo>, IClubeJogoService
    {
        private readonly IClubeJogoRepository _clubeJogoRepository;

        public ClubeJogoService(IClubeJogoRepository clubeJogoRepository)
             : base(clubeJogoRepository)
        {
            _clubeJogoRepository = clubeJogoRepository;
        }

    }
}
