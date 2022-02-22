using PaelytOnionArchi.Data.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Service.Login
{
    public interface ICostumerLoginService
    {
        Task<CustomerLogin> Login(string Email, string TransactionNumber);
    }
}
