using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class SuViewModel
    {

        public ObservableCollection<Product> SuListesi { get; set; }

        public SuViewModel()
        {

            SuListesi = new ObservableCollection<Product>()
            {
                new Product(70,5,"Abant Doğal Kaynak Suyu 1,5 L","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060191/abant-dogal-kaynak-suyu-1-5-l-aa2331.jpg",5000),
                new Product(71,5,"Erikli Su 6X1 L","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062215/08062215-cd81be.jpg",6500),
                new Product(72,5,"Erikli Su 5 L","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062203/08062203-2f4ec4.jpg",5650),
                new Product(73,5,"Erikli Su 12x500 Ml","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060028/08060028-53688c.jpg",7500),
                new Product(74,5,"Erikli Su 2X5 L Avantajlı Paket","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062217/08062217-22cae1.jpg",7000),


            };



        }
    }
}
