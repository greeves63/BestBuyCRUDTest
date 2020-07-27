using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyCRUDTest
{
    public class Products
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CategoryID { get; set; }

        public int OnSale { get; set; }

        public string StockLevel { get; set; }
    }
}
