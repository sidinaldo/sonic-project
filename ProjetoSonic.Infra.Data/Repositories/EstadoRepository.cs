
using System.Collections.Generic;
using System.Linq;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class EstadoRepository : RepositoryBase<Estado>, IEstadoRepository
    {
        public IEnumerable<Estado> BuscarPorNome(string nome)
        {
            return Db.Estados.Where(e => e.NomeEstado == nome);
        }
    }
}
