
using System.Collections.Generic;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;

namespace ProjetoSonic.Domain.Services
{
    public class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
            : base(estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public IEnumerable<Estado> BuscarPorNome(string nome)
        {
            return _estadoRepository.BuscarPorNome(nome);
        }
    }
}
