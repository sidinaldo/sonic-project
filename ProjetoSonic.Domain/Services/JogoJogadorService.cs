
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class JogoJogadorService : ServiceBase<JogoJogador>, IJogoJogadorService
    {
        private readonly IJogoJogadorRepository _jogoJogadorRepository;

        public JogoJogadorService(IJogoJogadorRepository jogoJogadorRepository)
            : base(jogoJogadorRepository)
        {
            _jogoJogadorRepository = jogoJogadorRepository;
        }
    }
}
