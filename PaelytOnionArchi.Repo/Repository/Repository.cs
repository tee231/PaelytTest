using Microsoft.EntityFrameworkCore;
using PaelytOnionArchi.Data;
using PaelytOnionArchi.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Repo.Repository
{


    public class Repository<T> : IRepository<T> where T : ApplicationUser
    {
        private readonly ApplicationDbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public List<Customer> GetAll()
        {

            var e = context.Set<Customer>().ToList();

             return e;

        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
            //throw new NotImplementedException();

        }
        public int Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
          var ret =  context.SaveChanges();
            return ret;
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            //context.SaveChanges();
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

       
    }
}
