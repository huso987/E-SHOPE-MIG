using eShopOnContainers.Core.Models.Item;
using eShopOnContainers.Core.Services.Marketing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.ViewModels
{
    public class AramalarViewModel
    {

        ProductService productService = new ProductService();

        



        public AramalarViewModel()
        {

            
        }


        public  Task<List<Product>> FindAllProduct()
        {
            return Task.Run(() => productService.GetAllProduct());
        }


    }
}
