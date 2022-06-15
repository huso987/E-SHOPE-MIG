using eShopOnContainers.Core.DatabaseFolder;
using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Marketing
{
    public class ProductService
    {



        ProductDB productDb = new ProductDB();

        public ProductService()
        {

        }


        public async Task AddBasket(Product product)
        {

            await productDb.SaveProductToBasket(product);

        }

        public async Task AddFavorite(Product product)
        {

            await productDb.SaveProductToFavorite(product);

        }

        public async Task<List<Product>> GetAllProduct()
        {

            return await productDb.GetAllProduct();

        }

        public async Task RemoveBasket(int productId)
        {

            await productDb.DeleteProductFromBasket(productId);

        }

        public async Task RemoveFavorite(int productId)
        {

            await productDb.DeleteProductFromFavorite(productId);

        }

        public async Task<List<Product>> GetAllProductFromBasket()
        {

            return await productDb.GetAllProductFromBasket();

        }

        public async Task<List<Product>> GetAllProductFromFavorite()
        {

            return await productDb.GetAllProductFromFavorite();

        }

    }
}
