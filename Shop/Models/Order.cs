using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string User { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
