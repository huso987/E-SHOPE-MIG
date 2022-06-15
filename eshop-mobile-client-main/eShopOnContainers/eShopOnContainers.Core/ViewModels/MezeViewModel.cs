using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class MezeViewModel
    {

        public ObservableCollection<Product> MezeListesi { get; set; }

        public MezeViewModel()
        {

            MezeListesi = new ObservableCollection<Product>()
            {
                new Product(47,4,"Mezzetürk Rus Salatası 300 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19000913/mezzeturk-rus-salatasi-300-gr-ff4de8.jpg",2),
                new Product(48,4,"Mezzetürk Yaprak Sarma 300 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19000910/mezzeturk-yaprak-sarma-300-gr-e37a82.jpg",3),
                new Product(49,4,"Gurumen Haydari 200 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009856/19009856-300835.jpg",2),
                new Product(50,4,"Gurumen Beypazarı Yaprak Sarma 200 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009858/19009858-ae333b.jpg",3),
                new Product(51,4,"Gurumen Acılı Ezme 200 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009860/19009860-4c3fcf.jpg",2),



            };



        }
    }
}
