
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class JogadorAppService : AppServiceBase<Jogador>, IJogadorAppService
    {
        private readonly IJogadorService _jogadorService;

        public JogadorAppService(IJogadorService jogadorService)
            : base(jogadorService)
        {
            _jogadorService = jogadorService;
        }
    }
}
