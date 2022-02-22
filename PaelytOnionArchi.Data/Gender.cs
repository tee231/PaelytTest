using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Data
{
    public class Gender 
    {
       
       public int Id { get; set; }
        public string GenderName { get; set; }
        public virtual  Customer Customer { get; set; }
       //[ForeignKey("Customer")]
       // public int CustomerId { get; set; }
    }

}
