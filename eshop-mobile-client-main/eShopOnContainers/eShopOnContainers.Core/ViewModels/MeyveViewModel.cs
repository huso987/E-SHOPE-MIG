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

            MeyveListesi = new ObservableCollection<Product>()
            {
                new Product(6,1,"Elma (kg)","https://www.onurmarket.com/Uploads/UrunResimleri/buyuk/1124022-b1-4cc.jpg",13),
                new Product(7,1,"Karpuz","https://ayb.akinoncdn.com/products/2021/09/01/75000/26046557-0251-4e8a-bc62-15ce5879e562_size780x780_quality60_cropCenter.jpg",7),
                new Product(8,1,"Armut (kg)","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/27020005/27020005-d69d93-1650x1650.jpg",15),
                new Product(9,1,"Kayısı (kg)","http://www.entazem.com/Uploads/UrunResimleri/buyuk/Kayisi-500g-bf1a.jpg",10),
                new Product(10,1,"Erik (kg)","http://www.cagri.com/Uploads/UrunResimleri/buyuk/erik-can-kg-f6fe.jpg",13),



            };



        }
    }
}
