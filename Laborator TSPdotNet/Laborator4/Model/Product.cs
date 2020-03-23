using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Laborator4.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }
        [MaxLength(20)]
        public string ProductName { get; set; }
        public decimal Stock { get; set; }
        public decimal Price { get; set; }
        public int Deleted { get; set; }
        public int OrderDetailsId { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        protected Product() { }
    }
}