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


        public async Task SepeteEkle(Product product)
        {

            await productDb.ÜrünleriSepeteEkle(product);

        }

        public async Task FavoriyeEkle(Product product)
        {

            await productDb.UrünleriFavoriyeEkle(product);

        }

        public async Task<List<Product>> UrünleriGetir()
        {

            return await productDb.ÜrünleriGetir();

        }

        public async Task SepettenKaldır(int productId)
        {

            await productDb.SepettenÜrünleriSil(productId);

        }

        public async Task FavoridenKaldır(int productId)
        {

            await productDb.FavoridenÜrünleriSil(productId);

        }

        public async Task<List<Product>> SepettenÜrünleriGetir()
        {

            return await productDb.SeppetenÜrünleriGetir();

        }

        public async Task<List<Product>> FavoridenÜrünleriGetir()
        {

            return await productDb.FavoridenÜrünleriGetir();

        }

    }
}
