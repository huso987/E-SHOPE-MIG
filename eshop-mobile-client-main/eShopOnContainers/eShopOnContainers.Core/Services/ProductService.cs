using eShopOnContainers.Core.DataBaseFolder;
using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services
{
    public class ProductService
    {
        ProductDB productdb = new ProductDB();

        public async Task SepeteEkle(Product aramaü)
        {

            await productdb.Sepettenürünüekle(aramaü);

        }
    }
}
