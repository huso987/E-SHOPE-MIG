using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Item
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string ProductImageUrl { get; set; }
        public int UnitPrice { get; set; }






        public Product()
        {

        }

        public Product(int Id, int CategoryId, string ProductName, string ProductImageUrl, int UnitPrice)
        {
            this.Id = Id;
            this.CategoryId = CategoryId;
            this.ProductName = ProductName;
            this.ProductImageUrl = ProductImageUrl;
            this.UnitPrice = UnitPrice;

        }



    }
}
