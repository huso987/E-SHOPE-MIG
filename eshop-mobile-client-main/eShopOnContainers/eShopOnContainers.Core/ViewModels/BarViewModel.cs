using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class BarViewModel
    {


        public ObservableCollection<Product> BarListesi { get; set; }

        public BarViewModel()
        {

            BarListesi = new ObservableCollection<Product>()
            {
                new Product(19,3,"Eti Lifalif Kırmızı Meyveli Yulaf Bar 35 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07161717/07161717-d8db81.jpg",8),
                new Product(20,3,"Eti Lifalif Kuru Meyveli Yulaf Bar 35 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07169803/07169803-a6de97.jpg",7),
                new Product(21,3,"Nestle Nesfit Çilekli Bar 23,5 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05099120/05099120-0c9186.jpg",8),
                new Product(22,3,"Fellas Optimum Fındıklı Ve Kakaolu Meyve Barı 32G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07199717/07199717-44973d.jpg",9),



            };



        }
    }
}
