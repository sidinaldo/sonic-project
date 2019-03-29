
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class MunicipioService : ServiceBase<Municipio>, IMunicipioService
    {
        private readonly IMunicipioRepository _municipioRepository;

        public MunicipioService(IMunicipioRepository municipioRepository)
            : base(municipioRepository)
        {
            _municipioRepository = municipioRepository;
        }

        
    }
}
