using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class IslakHavluViewModel
    {

        public ObservableCollection<Product> IslakHavluListesi { get; set; }

        public IslakHavluViewModel()
        {

            IslakHavluListesi = new ObservableCollection<Product>()
            {
                new Product(76,6,"Komili Islak Havlu","http://www.karisikmarket.com/Uploads/UrunResimleri/buyuk/komili-islak-mendil-70-adet-ac47-0.jpg",14),
                new Product(77,6,"Pella Islak Havlu","https://img.epttavm.com/pimages/592/100/593/608ba715a73aa.jpg?v=201910111519",13),
                new Product(78,6,"Mendiva Islak Havlu","https://ayb.akinoncdn.com/products/2019/02/04/1349/371cbded-65e4-4c4b-ba9d-f6cdf1ccbd08_size780x780_quality60_cropCenter.jpg",11),
                new Product(79,6,"Sleepy Islak Havlu","https://www.tasomarket.com/files/products/sleepy-islak-havlu-leylak-kokulu-kapakli-90li-622-islak-mendil-havlu-sleepy-417660-23-B.jpg",13),



            };



        }
    }
}
