using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public int UnitPrice { get; set; }
    

        public Product()
        {

        }
        public Product(string ProductName, string ProductImageUrl, int UnitPrice)
        {

            this.ProductName = ProductName;
            this.ProductImageUrl = ProductImageUrl;
            this.UnitPrice = UnitPrice;

        }

    }
}
