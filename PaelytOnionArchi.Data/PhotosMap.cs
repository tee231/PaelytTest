using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Data
{
    public class PhotosMap
    {
        public PhotosMap(EntityTypeBuilder<Photos> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.CustomerId);
            
            //entityBuilder.Property(t => t.Customer);
           // entityBuilder.HasOne(e => e.Customer).WithMany(r => r.Photos);
            // entityBuilder.Property(t => t.Customer).IsRequired();
            // entityBuilder.Property(t => t.TransactionNumber);
        }
    }
}
