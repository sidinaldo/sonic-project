using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class JogoJogadorEventoAppService : AppServiceBase<JogoJogadorEvento>, IJogoJogadorEventoAppService
    {
        private readonly IJogoJogadorEventoService _JogoJogadorEventoService;

        public JogoJogadorEventoAppService(IJogoJogadorEventoService jogoJogadorEventoService)
            : base(jogoJogadorEventoService)
        {
            _JogoJogadorEventoService = jogoJogadorEventoService;
        }

    }
}
