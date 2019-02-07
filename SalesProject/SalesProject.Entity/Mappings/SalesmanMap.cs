using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SalesProject.Model;
using System.Data.Entity.ModelConfiguration;
namespace SalesProject.Entity.Mappings
{
    public class SalesmanMap:EntityTypeConfiguration<Salesman>
    {
        public SalesmanMap()
        {
            ToTable("tbSalesman");
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50).IsRequired();

        }
    }
}
