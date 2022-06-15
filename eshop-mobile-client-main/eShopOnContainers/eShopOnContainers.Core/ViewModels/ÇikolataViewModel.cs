using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class ÇikolataViewModel
    {

        public ObservableCollection<Product> ÇikolataListesi { get; set; }

        public ÇikolataViewModel()
        {

            ÇikolataListesi = new ObservableCollection<Product>()
            {
                new Product(23,3,"Nestle 1927 Bol Sütlü Kare Çikolata 60 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07018051/07018051-34377d.jpg",8),
                new Product(24,3,"Nestle Classic Bitter Kare Çikolata 60 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07037273/07037273-57e752.jpg",10),
                new Product(25,3,"Milka Oreolu Çikolata 100 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07049998/07049998-beacdc.jpg",7),
                new Product(26,3,"Milka Çilekli Yoğurtlu Tablet Çikolata 100 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07040658/07040658-987649.jpg",10),
                new Product(27,3,"Nestle Damak Antep Fıstıklı Baklavalı Beyaz Çikolata 60G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07033892/07033892-3e26b3.jpg",9),



            };



        }
    }
}
