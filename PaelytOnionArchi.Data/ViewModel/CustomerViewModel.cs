using System.Collections.Generic;
using System.Web.Mvc;

namespace PaelytOnionArchi.Data.ViewModel
{
    public  class CustomerViewModel /*: ApplicationUser*/
    {
        
        public Customer Customer { get; set; } // this brings in everything in the Customer Class to the viewmodel
        public IEnumerable<SelectListItem> Gender { get; set; }

        //public string Name { get; set; }
        //public string LastName { get; set; }

        // public string Gender { get; set; }
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }
        //public string TransactionNumber { get; set; }


        //[Required]
        //[Display(Name = "Gender")]
        //public string Gender { get; set; }   //all this does is to display the "Gender" name
        // this displays the various gender options such as male and female


        //public ICollection<Photos> Photos { get; set; }

    }
}
