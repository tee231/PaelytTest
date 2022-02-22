using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Data
{
    public class Customer : ApplicationUser
    {
       
       
        public string Name { get; set; }
        public string LastName { get; set; }

       // public string Gender { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string TransactionNumber { get; set; }
        [ForeignKey("Gender")]
        public virtual Gender CustomerGender { get; set; }
      

        public ICollection<Photos> Photos { get; set; }

    }

  

}
