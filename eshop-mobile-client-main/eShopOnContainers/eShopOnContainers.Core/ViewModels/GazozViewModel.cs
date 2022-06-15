using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class GazozViewModel
    {

        public ObservableCollection<Product> GazozListesi { get; set; }

        public GazozViewModel()
        {
            GazozListesi = new ObservableCollection<Product>()
            {

                new Product(59,4,"Sprite Gazoz 1L","https://d2uiaykj5yb3c0.cloudfront.net/gun/img/p/6bf0e493-02a5-4a5a-8518-81338e768225.jpg",8),
                new Product(60,4,"Fruko Gazoz 2L","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/08011701/08011701-118bfb-1650x1650.jpg",12),
                new Product(61,4,"Çamlıca Gazoz 1,5L","https://cdnd-tr.ceptesok.com/product/1000x1000/camlica-gazoz-15-lt-49872.jpg",10),
                new Product(62,4,"Niğde Gazozu 250mL","https://reimg-carrefour.mncdn.com/mnresize/600/600/productimage/30082461/30082461_0_MC/8796797567026_1499977606272.jpg",8),

            };
        }

    }
}
