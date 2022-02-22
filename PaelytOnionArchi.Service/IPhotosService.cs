using PaelytOnionArchi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Service
{
    public interface IPhotosService
    {
      //  IEnumerable<Customer> GetAllCustomers();
        void Add(Photos photos);
        
        void Delete(int Id);
        Photos GetCustomerbyId(int Id);

    }
}
