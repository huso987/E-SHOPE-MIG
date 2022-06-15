using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class YumurtaViewModel
    {

        public ObservableCollection<Product> YumurtaListesi { get; set; }

        public YumurtaViewModel()
        {

            YumurtaListesi = new ObservableCollection<Product>()
            {
                new Product(35,3,"Köy Yumurtası 15'li","https://www.kalemarketleri.com/Uploads/UrunResimleri/buyuk/hacioglu-yumurta-beyaz-15-liyumurta-af22.jpg",22),
                new Product(36,3,"Yumurta 30'lu","https://st1.myideasoft.com/idea/gm/43/myassets/products/727/36727-1.jpg?revision=1615999063",38),
                new Product(37,3,"Yumurtacım 15'li","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/20001975/20001975-cdebd9.jpg",26),
                new Product(38,3,"Keskinoğlu Yumurta 30'lu","https://d2uiaykj5yb3c0.cloudfront.net/hanifpehlivanoglu/img/p/69cbc711-b726-415f-a3ea-1b4df7c2a706-1625525819291.jpg",33),



            };



        }
    }
}
