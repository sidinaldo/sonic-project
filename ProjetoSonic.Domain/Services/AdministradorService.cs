
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class AdministradorService  : ServiceBase<Administrador>, IAdministradorService
    {
        private readonly IAdministradorRepository _administradorRepository;

        public AdministradorService(IAdministradorRepository administradorRepository)
            : base(administradorRepository)
        {
            _administradorRepository = administradorRepository;
        }

        public IEnumerable<Administrador> BuscarPorFuncao(string funcao)
        {
            return _administradorRepository.BuscarPorFuncao(funcao); 
        }
    }
}
