
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Services;
using ProjetoSonic.Application.Interface;

namespace ProjetoSonic.Application
{
    public class AdministradorAppService : AppServiceBase<Administrador>, IAdministradorAppService
    {
        private readonly IAdministradorService _administradorService;

        public AdministradorAppService(IAdministradorService administradorService)
            : base(administradorService)
        {
            _administradorService = administradorService;
        }

        public IEnumerable<Administrador> BuscarPorFuncao(string funcao)
        {
            return _administradorService.BuscarPorFuncao(funcao);
        }
    }

}