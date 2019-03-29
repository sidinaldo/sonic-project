
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class CampoRepository : RepositoryBase<Campo>, ICampoRepository
    {
        public IEnumerable<Campo> BuscarPorNome(string nome)
        {
            return Db.Campos.Where(c => c.NomeCampo == nome);
        }

    }
}
