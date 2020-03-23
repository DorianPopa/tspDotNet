using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Laborator4.Model
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public int Deleted { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

        protected OrderDetails() { }
    }
}