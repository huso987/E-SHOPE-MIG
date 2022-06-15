using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class EnergyDrinkViewModel
    {

        public ObservableCollection<Product> EnergyDrinkListesi { get; set; }
        public EnergyDrinkViewModel()
        {

            EnergyDrinkListesi = new ObservableCollection<Product>()
            {
                new Product(52,4,"Monster","https://d2uiaykj5yb3c0.cloudfront.net/hanifpehlivanoglu/img/p/97d1c886-6f55-4ae8-83dc-82435af08917-1625527879939.jpg",12),
                new Product(53,4,"Red Bull","https://www.iyas.com.tr/images/thumbs/0002590_red-bull-enerji-icecegi-473-ml_510.jpg",11),
                new Product(54,4,"Powerade 500mL","https://ayb.akinoncdn.com/products/2021/04/06/1830/1e6f9355-95f6-4cfb-91c3-976710ccc53e_size780x780_quality60_cropCenter.jpg",10),
                new Product(55,4,"Powerade 500mL","https://reimg-carrefour.mncdn.com/mnresize/600/600/productimage/30032808/30032808_0_MC/8796493316146_1580815003139.jpg",10),
            };

        }


    }
}
