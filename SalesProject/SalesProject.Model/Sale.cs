using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int SalesmanId { get; set; }
        public virtual Salesman Salesman { get; set; }
        
        public override string ToString()
        {
            return this.Id.ToString();
        }

    }
}
