using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesProject.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SalesProject.Entity.Mappings
{
    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("tbProduct");
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50).IsRequired();
        }
    }
}
