using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class CayViewModel
    {

        public ObservableCollection<Product> CayListesi { get; set; }

        public CayViewModel()
        {
            CayListesi = new ObservableCollection<Product>()
            {
                new Product(43,4,"Doğuş Çay 1kg","https://productimages.hepsiburada.net/s/19/1500/9830598967346.jpg",20),
                new Product(44,4,"Çaykur 1kg","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/03111303/03111303-949450-1650x1650.jpg",25),
                new Product(45,4,"Filiz Çay 1kg","https://img-bizimtoptan.mncdn.com/Content/Images/Thumbs/1545818.jpeg",20),
                new Product(46,4,"Lipton Çay 1kg","https://www.imcmarket.com/resimler/8R070E7GA3V3D2LMG2YR.jpg",30),

            };

        }

    }
}
