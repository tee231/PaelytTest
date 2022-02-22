using PaelytOnionArchi.Data;
using PaelytOnionArchi.Repo.Interface;
using PaelytOnionArchi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Repo.Repository
{
   public class CustomerRepository : ICustomerService
    {
        private readonly ApplicationDbContext _application;
        public CustomerRepository(ApplicationDbContext application)
        {
            _application = application;
        }
        public void Add(Customer customer)
        {
            _application.Set<Customer>().AddAsync(customer);
            _application.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Edit(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerbyId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
