
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class JogoJogadorEventoService : ServiceBase<JogoJogadorEvento>, IJogoJogadorEventoService
    {
        private readonly IJogoJogadorEventoRepository _jogoJogadorEventoRepository;

        public JogoJogadorEventoService(IJogoJogadorEventoRepository jogoJogadorEventoRepository)
             : base(jogoJogadorEventoRepository)
        {
            _jogoJogadorEventoRepository = jogoJogadorEventoRepository;
        }
        
    }
}
