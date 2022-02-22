using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Data
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public virtual string Address { get; set; }
        [Display(Name = "Date of birth")]
        public  virtual DateTime Dob { get; set; }
        // public string Address { get; set; }

        public string Subject { get; set; }

        public virtual string Content { get; set; }
    }
}
