using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SalesProject.Model;


namespace SalesProject.Entity.Mappings
{
    public class SaleMap:EntityTypeConfiguration<Sale>
    {
        public SaleMap()
        {
            ToTable("tbSale");
            HasKey(x => x.Id);
   
            HasRequired(x => x.Product);
            HasRequired(x => x.Salesman);
        }
    }
}
