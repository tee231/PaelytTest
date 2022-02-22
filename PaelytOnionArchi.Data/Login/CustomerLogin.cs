using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Data.Login
{
    public class CustomerLogin : ApplicationUser
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string TransactionNumber { get; set; }
    }
}
