using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;


namespace ProjetoSonic.Application
{
    public class FuncaoAppService : AppServiceBase<Funcao>, IFuncaoAppService
    {
        private readonly IFuncaoService _funcaoService;

        public FuncaoAppService(IFuncaoService funcaoService)
            : base(funcaoService)
        {
            _funcaoService = funcaoService;
        }
    }
}
