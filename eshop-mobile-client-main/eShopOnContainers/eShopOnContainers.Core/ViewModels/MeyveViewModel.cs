using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class MeyveViewModel
    {


        public ObservableCollection<Product> MeyveListesi { get; set; }



        public MeyveViewModel()
        {
            MeyveListesi = new ObservableCollection<Product>(){

                new Product(11,2,"Avokado Adet","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28010004/28010004-10a053.jpg",75),
                new Product(12,2,"Ananas Adet","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27501003/-ananas-adet-c1fa49.jpg",65),
                new Product(13,2,"Erik İmam Ekstra 500 Gr","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27119096/27119096-1fadbe.jpg",60),
                new Product(14,2,"Kavun Çankırı Ekstra 1 Adet" ,"https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27208050/27208050-e36a26.jpg",96),

            };



        }


    }
}
