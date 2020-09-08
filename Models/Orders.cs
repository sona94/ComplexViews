using System;
using System.Collections.Generic;

namespace ComplexViews.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int OrderNum { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int Qty { get; set; }

        public Customers Customer { get; set; }
        public Products Product { get; set; }
    }
}
