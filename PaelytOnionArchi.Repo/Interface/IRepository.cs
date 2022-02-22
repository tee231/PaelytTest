using PaelytOnionArchi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Repo.Interface
{
    public interface IRepository<T> where T : ApplicationUser
    {
       // IEnumerable<T> GetAll();
        List<Customer> GetAll();
        T Get(long id);
        int  Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
