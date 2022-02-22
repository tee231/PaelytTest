using PaelytOnionArchi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Service
{
	public interface ICustomerService
	{
		//List<Customer> GetAllCustomers();
		IEnumerable<Customer> GetAllCustomers();
		int  Add(Customer customer);
		void Edit(Customer customer);
		void Delete(int Id);
		Customer GetCustomerbyId(int Id);

		
	}
}
