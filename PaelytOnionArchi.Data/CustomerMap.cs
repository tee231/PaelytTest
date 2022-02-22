using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Data
{
   public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Email).IsRequired();
            entityBuilder.Property(t => t.TransactionNumber);
            //entityBuilder.HasMany(t => t.Photos).WithOne(u => u.Customer).HasForeignKey<Photos>(x => x.Id);
            //  entityBuilder.HasMany(t => t.Photos).WithOne(u => u.Customer).HasForeignKey(c => c.Id);
            // entityBuilder.HasOne(e => e.Customer).WithMany(r => r.Photos);



        }
    }
}
