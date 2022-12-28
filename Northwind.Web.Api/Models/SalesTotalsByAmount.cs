using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class SalesTotalsByAmount
    {
        public double? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; } = null!;
        public DateTime? ShippedDate { get; set; }
    }
}
