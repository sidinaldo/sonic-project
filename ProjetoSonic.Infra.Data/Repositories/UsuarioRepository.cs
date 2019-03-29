using ProjetoSonic.Domain.Entities;
using ProjetoSonic.Domain.Interfaces;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public bool UsuarioEspecial(Usuario usuario)
        {
            return usuario.Ativo && usuario.ClubeQueTorce == "Olho D'água Futebol Clube";
        }       

    }
}
