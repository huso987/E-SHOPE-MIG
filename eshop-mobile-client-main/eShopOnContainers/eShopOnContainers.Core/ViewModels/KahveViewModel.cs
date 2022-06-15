using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class KahveViewModel
    {
        public ObservableCollection<Product> KahveListesi { get; set; }

        public KahveViewModel()
        {

            KahveListesi = new ObservableCollection<Product>()
            {
                new Product(39,4,"Türk Kahvesi 300gr","https://cdn03.ciceksepeti.com/cicek/kc5313729-1/XL/kahve-dunyasi-orta-kavrulmus-turk-kahvesi-100-gr--5-li-paket-----------------------------------------kc5313729-1-8542a88293ed4ac0ad45f9258f485837.jpg",25),
                new Product(40,4,"Nescafe Blend 250gr","https://ayb.akinoncdn.com/products/2020/12/11/52303/9086ceae-0860-4202-ac62-e242721d058b_size780x780_quality60_cropCenter.jpg",35),
                new Product(41,4,"Jacobs Kahve 200gr","https://www.trakyagross.com/image/cache/catalog/urunler/jacobs/jacobs-monarch-200gr-paket-550x550.jpg",25),
                new Product(42,4,"Filtre Kahve 250gr","http://www.cagri.com/Uploads/UrunResimleri/buyuk/kahve-dunyasi-filtre-kahve-250-gr-0668.jpg",35),



            };

        }
    }
}
