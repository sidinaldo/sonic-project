using System.Collections.Generic;
using System.Linq;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class ClubeRepository : RepositoryBase<Clube>, IClubeRepository
    {
        public IEnumerable<Clube> ClubeDoBairro(string bairro)
        {
            return Db.Clubes.Where(c => c.Bairro.NomeBairro == bairro);//buscar po clube do bairro
        }

    }
}
