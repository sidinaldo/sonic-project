
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class EventoAppService : AppServiceBase<Evento>, IEventoAppService
    {
        private readonly IEventoService _eventoService;

        public EventoAppService(IEventoService eventoService)
            : base(eventoService)
        {
            _eventoService = eventoService;
        }

    }
}
