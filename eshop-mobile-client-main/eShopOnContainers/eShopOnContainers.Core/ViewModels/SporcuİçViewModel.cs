using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class SporcuİçViewModel
    {

        public ObservableCollection<Product> SporcuİçListesi { get; set; }

        public SporcuİçViewModel()
        {

            SporcuİçListesi = new ObservableCollection<Product>()
            {
                new Product(76,6,"Sırma Teatoks Elmalı & Papatyalı İçecek 400Ml","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062274/08062274-be6fda.jpg",14),
                new Product(77,6,"Sırma Kolajen Portakallı & Ananas Aromalı İçecek 400 Ml","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062278/08062278-f2e8ce.jpg",13),
                new Product(78,6,"Powerade Sun Rush Portakal Aromalı Spor İçeceği 500 Ml","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08110009/08110009-7a3b0b.jpg",11),
                new Product(79,6,"Sırma Protein Çilek & Ahududu Aromalı İçecek 400 Ml","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062277/08062277-65d2b4.jpg",13),



            };



        }
    }
}
