
using ProjetoSonic.Domain.Interfaces;
using ProjetoSonic.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoSonic.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoSonicContexto Db = new ProjetoSonicContexto();  //contexto do banco de dados

        // Implementando os metodos em IRepositoryBase

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj); //setar o objeto para ser salvo
            Db.SaveChanges(); // metodo salvar

        }

        public TEntity GetById(int id)
        {
           return Db.Set<TEntity>().Find(id);//busca pela chave para Listar os dados
            
        }       

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList(); //retorna todos em formato de lista
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified; //objeto já existe no banco e vai ser modificado
            Db.SaveChanges();
        }
        
        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj); // remover objeto
            Db.SaveChanges();
        }      

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
