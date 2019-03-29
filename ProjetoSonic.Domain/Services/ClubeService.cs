

using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class ClubeService : ServiceBase<Clube>, IClubeService
    {
        private readonly IClubeRepository _clubeRepository;

        public ClubeService(IClubeRepository clubeRepository)
            :base(clubeRepository)
        {
            _clubeRepository = clubeRepository;
        }


        public IEnumerable<Clube> ClubeDoBairro(string bairro)
        {
            return _clubeRepository.ClubeDoBairro(bairro);
        }
    }
}
