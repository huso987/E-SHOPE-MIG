using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class GazlıİçecekViewModel
    {

        public ObservableCollection<Product> BulasikMakinesiListesi { get; set; }

        public GazlıİçecekViewModel()
        {

            BulasikMakinesiListesi = new ObservableCollection<Product>()
            {
                new Product(66,5,"Coca-Cola Zero Sugar 1 L","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08010701/08010701-8c549e.png",5000),
                new Product(67,5,"Coca-Cola Zero Sugar 6X250 Ml Kutu","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08019112/08019112-843f91.png",4500),
                new Product(68,5,"Fanta Portakal Aromalı Gazoz 1 L","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08022000/08022000-99cd8c.jpg",4350),
                new Product(69,5,"Schweppes Mandalina Aromalı Gazlı İçecek Pet 1 L","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08022710/08022710-311a6f.jpg",5250),



            };



        }

    }
}
