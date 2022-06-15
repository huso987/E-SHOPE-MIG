using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using eShopOnContainers.Core.Views;

namespace eShopOnContainers.Core.ViewModels
{
   
    public class MigrosevViewModel
    {
        public ObservableCollection<Product> MigrosevListesi { get; set; }

        public MigrosevViewModel()
        {
            MigrosevListesi = new ObservableCollection<Product>()
            {
                new Product{ProductName ="Migros Ev Lezzetleri Tavuklu Pirinç Pilavı 210 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009224/19009224-0bc7d9.jpg",UnitPrice=21},
                 new Product{ProductName ="Migros Ev Lezzetleri Şehriyeli Pirinç Pilavı 180 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009221/19009221-3cb24a.jpg",UnitPrice=21},
                  new Product{ProductName ="Migros Ev Lezzetleri Tavuklu Trüflü Wrap 240 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009222/19009222-8babcf.jpg",UnitPrice=30},
                   new Product{ProductName ="Migros Ev Lezzetleri Tahıllı Salata 170 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009233/19009233-2239b3.png",UnitPrice=20},
                 new Product {ProductName ="Migros Ev Lezzetleri Antep Fıstıklı Sufle 140 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009225/19009225-15afd9.jpg",UnitPrice=22},
                  new Product{ProductName ="Migros Ev Lezzetleri Izgara Köfte ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009864/19009864-adb1a7.jpg",UnitPrice=18 }
           };
        }
    }
}
