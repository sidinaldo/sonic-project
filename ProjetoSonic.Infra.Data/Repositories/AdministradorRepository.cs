using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class AdministradorRepository : RepositoryBase<Administrador>, IAdministradorRepository
    {
        public IEnumerable<Administrador> BuscarPorFuncao(string funcao)
        {
            return Db.Administradores.Where(a => a.Funcao.NomeFuncao == funcao);//buscar pela funcao
        }
    }
}
