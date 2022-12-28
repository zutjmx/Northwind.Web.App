﻿using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class ProductsByCategory
    {
        public string CategoryName { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public ulong Discontinued { get; set; }
    }
}
