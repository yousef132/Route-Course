using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Entities;

namespace BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext Context;


        public GenericRepository(AppDbContext context)
        {
            Context = context;
        }


        public void Add(T Entity)
        {
            // Set<T>()  is used to access the DbSet<T> corresponding to the type T.
            // T Must Be Department Or Employee So we Use This Constraint (where T : BaseEntity)
            //Where BaseEntity Is the Parent of Deparment & Employee 
            // It Can has the common properties for Deparment & Employee 
            Context.Set<T>().Add(Entity);
        }

        public void Delete(T Entity)
        {
            Context.Set<T>().Remove(Entity);
        }

        public IEnumerable<T> GetAll() => Context.Set<T>().ToList();


        // Didn't Use FirstOrDefault Because it is Generic Type
        // Find(id) => Get Id (PK) and Return Entity With This Id 
        public T GetEntityById(int? id) => Context.Set<T>().Find(id);


        public void Update(T Entity) => Context.Set<T>().Update(Entity);
    }
}