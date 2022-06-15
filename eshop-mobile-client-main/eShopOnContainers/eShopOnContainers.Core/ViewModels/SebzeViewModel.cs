using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class SebzeViewModel
    {

        public ObservableCollection<Product> SebzeListesi { get; set; }

        

        public SebzeViewModel()
        {


            SebzeListesi = new ObservableCollection<Product>()
            {
                new Product(1,1,"Domates (kg)","https://st2.myideasoft.com/idea/ad/25/myassets/products/210/domates-ne-kadar.jpg?revision=1634649401",17),
                new Product(2,1,"Salatalık (kg)","https://ayb.akinoncdn.com/products/2021/09/01/7095/7a472d55-53f1-40b0-8a80-d1b28985eeea_size780x780_quality60_cropCenter.jpg",20),
                new Product(3,1,"Pırasa (kg)","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/28330099/pirasa-kg-108f2f-1650x1650.jpg",13),
                new Product(4,1,"Biber (kg)","http://www.cagri.com/Uploads/UrunResimleri/buyuk/biber-carliston-kg-6216.jpg",20),
                new Product(5,1,"Havuç (kg)","http://www.cagri.com/Uploads/UrunResimleri/buyuk/havuc-kg-d07b.jpg",16),



            };
        }




        




    }
}
