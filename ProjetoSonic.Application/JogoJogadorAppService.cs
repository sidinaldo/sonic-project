
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class JogoJogadorAppService : AppServiceBase<JogoJogador>, IJogoJogadorAppService
    {
        private readonly IJogoJogadorService _jogoJogadorService;

        public JogoJogadorAppService(IJogoJogadorService jogoJogadorService)
            : base(jogoJogadorService)
        {
            _jogoJogadorService = jogoJogadorService;
        }
    }
}
