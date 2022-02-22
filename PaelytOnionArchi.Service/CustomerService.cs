

using PaelytOnionArchi.Data;
using PaelytOnionArchi.Repo.Interface;
using System.Collections.Generic;

namespace PaelytOnionArchi.Service
{
    public class CustomerService : ICustomerService
    {
       
        private IRepository<Customer> _customerRepository;
        
        public CustomerService(IRepository<Customer> customerRepository)
        {
            
            _customerRepository = customerRepository;
        }
        public int  Add(Customer customer)
        {
            //_application.Set<Customer>().AddAsync(customer);
            //_application.SaveChanges();
           var ret = _customerRepository.Insert(customer);
            return ret;
        }

       


        public void Edit(Customer customer)
        {
            _customerRepository.Update(customer);
        }

      

        public Customer GetCustomerbyId(int Id)
        {
            return _customerRepository.Get(Id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
           
            return _customerRepository.GetAll();
        }

        public void Delete(int Id)
        {
            Customer customer = GetCustomerbyId(Id);
            _customerRepository.Remove(customer);
            _customerRepository.SaveChanges();
        }
    }
}