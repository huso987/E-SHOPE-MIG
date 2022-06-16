using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Marketing
{
    public interface IProductService
    {
        Task SepeteEkle(Product product);
        Task FavoriyeEkle(Product product);
        Task<List<Product>> UrünleriGetir();
         Task SepettenKaldır(int productId);
        Task FavoridenKaldır(int productId);
        Task<List<Product>> SepettenÜrünleriGetir();
        Task<List<Product>> FavoridenÜrünleriGetir();
    }
}
