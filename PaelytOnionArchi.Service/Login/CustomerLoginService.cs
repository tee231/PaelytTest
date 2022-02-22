using PaelytOnionArchi.Data.Login;
using PaelytOnionArchi.Repo;
using PaelytOnionArchi.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Service.Login
{
    public class CustomerLoginService : ICostumerLoginService
    {

        private readonly IRepository<CustomerLogin> _customerlogin;

        public CustomerLoginService(IRepository<CustomerLogin> login)
        {

            _customerlogin = login;


        }

        public Task<CustomerLogin> Login(string Email, string TransactionNumber)
        {
            throw new NotImplementedException();
        }

        

    }
}
