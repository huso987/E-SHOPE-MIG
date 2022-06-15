using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class MigrosEvLezzetleriViewModel
    {

        public ObservableCollection<Product> MigrosEvListesi { get; set; }

        public MigrosEvLezzetleriViewModel()
        {

            MigrosEvListesi = new ObservableCollection<Product>()
            {
                new Product(6,1,"Migros Ev Lezzetleri Etli Yaprak Sarma 250 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009841/19009841-bbc256.jpg",13),
                new Product(7,1,"Migros Ev Lezzetleri Limonlu Cheesecake 125 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009833/19009833-c22fbb.jpg",7),
                new Product(8,1,"Migros Ev Lezzetleri Tavuklu Cheddarlı Wrap 185 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009830/19009830-7cbb08.jpg",15),
                new Product(9,1,"Migros Ev Lezzetleri Tavuklu Pirinç Pilavı 210 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009224/19009224-0bc7d9.jpg",10),
               



            };



        }
    }
}
