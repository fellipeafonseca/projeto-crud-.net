using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SalesProject.Model;
using SalesProject.Entity.Mappings;

namespace SalesProject.Entity
{
    public class SalesProjectDataContext:DbContext
    {
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public SalesProjectDataContext()
            : base("SalesProjectConnectionString")
        {
            Database.SetInitializer<SalesProjectDataContext>(new SalesProjectDataContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new SalesmanMap());
            modelBuilder.Configurations.Add(new SaleMap());
            base.OnModelCreating(modelBuilder);
        }
    }

    public class SalesProjectDataContextInitializer : DropCreateDatabaseIfModelChanges<SalesProjectDataContext>
    {
        protected override void Seed(SalesProjectDataContext context)
        {
            
            base.Seed(context);
        }
    }
}
