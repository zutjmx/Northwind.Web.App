﻿using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public double? Subtotal { get; set; }
    }
}
