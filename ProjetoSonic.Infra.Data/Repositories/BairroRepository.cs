
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class BairroRepository : RepositoryBase<Bairro>, IBairroRepository
    {
        
        public IEnumerable<Bairro> BuscaPorNome(string nome)
        {
            return Db.Bairros.Where(b => b.NomeBairro == nome);
        }
    }
}
