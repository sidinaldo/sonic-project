using System.Collections.Generic;

namespace ProjetoSonic.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity :class
    {
        //metodos do CRUD
        void Add(TEntity obj); //Adicionar
        TEntity GetById(int id);//Retornar(listar)
        IEnumerable<TEntity> GetAll();// Retorna uma lista(select)
        void Update(TEntity obj);//Atualizar
        void Remove(TEntity obj);//Remover
        void Dispose();// destruir o objeto instanciado na memória

    }
}
