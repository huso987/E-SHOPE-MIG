using eShopOnContainers.Core.Models.Item;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.DatabaseFolder
{
    public class ProductDB
    {

        readonly FirebaseClient firebase = new FirebaseClient("https://migroshacerhuso-default-rtdb.europe-west1.firebasedatabase.app/");

        public async Task ÜrünleriSepeteEkle(Product product)
        {


            await firebase.Child("Sepet").PostAsync(JsonConvert.SerializeObject(product));//sepet


        }

        public async Task UrünleriFavoriyeEkle(Product product)
        {

            await firebase.Child("Favoriler").PostAsync(JsonConvert.SerializeObject(product));


        }

        public async Task SepettenÜrünleriSil(int productId)
        {
            var deleteProduct = (await firebase.Child("Sepet").OnceAsync<Product>()).Where(a => a.Object.Id == productId).FirstOrDefault();
            await firebase.Child("Sepet").Child(deleteProduct.Key).DeleteAsync();

        }

        public async Task FavoridenÜrünleriSil(int productId)
        {
            var deleteProduct = (await firebase.Child("Favoriler").OnceAsync<Product>()).Where(a => a.Object.Id == productId).FirstOrDefault();
            await firebase.Child("Favoriler").Child(deleteProduct.Key).DeleteAsync();

        }

        public async Task<List<Product>> ÜrünleriGetir()
        {

            return (await firebase
              .Child("Ürünler")
              .OnceAsync<Product>()).Select(item => new Product
              {
                  Id = item.Object.Id,
                  CategoryId = item.Object.CategoryId,
                  ProductName = item.Object.ProductName,
                  ProductImageUrl = item.Object.ProductImageUrl,
                  UnitPrice = item.Object.UnitPrice,
              }).ToList();

        }

        public async Task<List<Product>> SeppetenÜrünleriGetir()
        {

            return (await firebase
              .Child("Sepet")  // sepet
              .OnceAsync<Product>()).Select(item => new Product
              {
                  Id = item.Object.Id,
                  CategoryId = item.Object.CategoryId,
                  ProductName = item.Object.ProductName,
                  ProductImageUrl = item.Object.ProductImageUrl,
                  UnitPrice = item.Object.UnitPrice,
              }).ToList();
        }


        public async Task<List<Product>> FavoridenÜrünleriGetir()
        {

            return (await firebase
              .Child("Favoriler")
              .OnceAsync<Product>()).Select(item => new Product
              {
                  Id = item.Object.Id,
                  CategoryId = item.Object.CategoryId,
                  ProductName = item.Object.ProductName,
                  ProductImageUrl = item.Object.ProductImageUrl,
                  UnitPrice = item.Object.UnitPrice,
              }).ToList();
        }


    }
}
