using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class JogoRepository : RepositoryBase<Jogo>, IJogoRepository
    {
        //public IEnumerable<Jogo> BuscarPorNome(string clube)
        //{
        //    //return Db.Jogos.Where(a => a.TimeA == clube || a.TimeB == clube );//buscar por time
        //}
    }
}
