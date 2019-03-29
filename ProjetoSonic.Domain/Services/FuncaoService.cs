
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services 
{
    public class FuncaoService : ServiceBase<Funcao>, IFuncaoService
    {
        private readonly IFuncaoRepository _funcaoRepository;

        public FuncaoService(IFuncaoRepository funcaoRepository)
            : base(funcaoRepository)
        {
            _funcaoRepository = funcaoRepository;

        }
    }
}
