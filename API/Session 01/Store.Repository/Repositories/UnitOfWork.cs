using Store.Data.Entities;
using Store.Data.StoreDbContext;
using Store.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly StoreDbContext context;
        private Hashtable repositories;

        public UnitOfWork(StoreDbContext context)
        {
            this.context = context;
        }

        public async Task<int> CompleteAsync()=>await context.SaveChangesAsync();

        public IGenericRepository<TEntity, TKey> Reposirory<TEntity, TKey>() where TEntity : BaseEntity<TKey>
        {
         
            if(repositories == null)
                repositories = new Hashtable();
              
            var entityKey = typeof(TEntity).Name;
            if(!repositories.ContainsKey(entityKey))
            {
                var repositoryType = typeof(GenericRepository<,>);
                var repositoryInsatnce = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity), typeof(TKey)),context);

                repositories.Add(entityKey, repositoryInsatnce);    
            }
            return (IGenericRepository<TEntity, TKey>) repositories[entityKey];
        }
    }
}
