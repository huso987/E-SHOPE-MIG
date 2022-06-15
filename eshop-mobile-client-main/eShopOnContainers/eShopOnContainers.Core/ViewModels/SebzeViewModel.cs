using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class SebzeViewModel
    {


        public ObservableCollection<Product> SebzeListesi { get; set; }

        public SebzeViewModel()
        {

            SebzeListesi = new ObservableCollection<Product>()
            {
                new Product(15,2,"Domates Salkım 500 G Paket Adet","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28089129/28089129-ca5410.jpg",35),
                new Product(16,2,"Hıyar Badem 500 G Paket Adet","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28136887/28136887-d4d1b2.jpg",25),
                new Product(17,2,"Patlıcan Kemer 500 G Paket Adet","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28309054/28309054-41821e.jpg",30),
                new Product(18,2,"Mısır Adet" ,"https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28270004/misir-adet-d61636.jpg",55),



            };



        }


    }
}
