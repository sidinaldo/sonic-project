using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Application
{
    public class MunicipioAppService : AppServiceBase<Municipio>, IMunicipioAppService
    {
        private readonly IMunicipioService _municipioService;

        public MunicipioAppService(IMunicipioService municipioService)
            : base(municipioService)
        {
            _municipioService = municipioService;
        }
    }
}
