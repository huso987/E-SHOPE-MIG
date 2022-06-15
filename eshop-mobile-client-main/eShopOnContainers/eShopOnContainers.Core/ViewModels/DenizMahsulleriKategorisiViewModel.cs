using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class DenizMahsulleriKategorisiViewModel
    {


        public ObservableCollection<Product> DenizMahsulleriListesi { get; set; }

        public DenizMahsulleriKategorisiViewModel()
        {

            DenizMahsulleriListesi = new ObservableCollection<Product>()
            {
                new Product(15,2,"Zargana (kg)","https://reimg-carrefour.mncdn.com/mnresize/600/600/productimage/30170555/30170555_0_MC/8801666891826_1530714434094.jpg",35),
                new Product(16,2,"Hamsi (kg)","https://www.onurmarket.com/Uploads/UrunResimleri/buyuk/1000626-aaa4-4.jpg",25),
                new Product(17,2,"Lüfer (kg)","https://www.sariyermarket.com/images/thumbs/0025191_lufer-adet_510.jpeg",30),
                new Product(18,2,"Somon (kg)" ,"https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/21000030/21000030-bc2b59-1650x1650.jpg",55),



            };



        }


    }
}
