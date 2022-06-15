using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class SütViewModel
    {

        public ObservableCollection<Product> SütListesi { get; set; }

        public SütViewModel()
        {

            SütListesi = new ObservableCollection<Product>()
            {
                new Product(23,3,"Sütaş Süt 1L","https://st2.myideasoft.com/idea/if/83/myassets/products/124/sm-urun-gorselleri-sut-ve-krema-512121-sut-3-5-tam-yagli-1l.jpg",8),
                new Product(24,3,"Pınar Süt 1L","https://cdnsta.avansas.com/mnresize/900/-/urun/77674/pinar-yagli-sut-500-ml-zoom-1.jpg",10),
                new Product(25,3,"İçim Süt 1L","https://esenlik.com.tr/icim-sut-1000-ml--p-2563.jpg",7),
                new Product(26,3,"Sek Süt 1L","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/11012010/11012010-a18da1-1650x1650.jpg",10),
                new Product(27,3,"Torku Süt 1L","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/11019904/torku-uht-sut-1-l-5fb2a0-1650x1650.jpg",9),



            };



        }
    }
}
