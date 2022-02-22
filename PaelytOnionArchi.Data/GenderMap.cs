using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Data
{
    public class GenderMap
    {
        public GenderMap(EntityTypeBuilder<Gender> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            //entityBuilder.Property(t => t.CustomerId);
            entityBuilder.HasData(
                new {Id =1, GenderName ="Male"  },
               new {Id = 2, GenderName = "Female" });
           


        }
    }
}
